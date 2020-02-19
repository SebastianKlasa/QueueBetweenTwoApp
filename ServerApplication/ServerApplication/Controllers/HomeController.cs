using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ServerApplication.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;
using System.Net.Mail;
using ServerApplication.Hubs;
using Microsoft.AspNetCore.SignalR;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ServerApplication.Controllers
{
    public class HomeController : Controller
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();

        public HomeController(IHubContext<ListHub> hubcontext)
        {
            HubContext = hubcontext;
        }

        private static IHubContext<ListHub> HubContext
        {
            get;
            set;
        }

        public IActionResult Index()
        {
            //await this.HubContext.Clients.All.SendAsync("ReceiveMessage", "gfda", "aaa");
            return View();
        }
        public IActionResult HireDetails(int id)
        {
            var hire = dataAccessLayer.GetHireData(id);
            hire.User = dataAccessLayer.GetUserData(hire.UserId);
            hire.Car = dataAccessLayer.GetCarData(hire.CarId);

            return View(hire);
        }
        public bool IsMailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public IActionResult PayForHire(int id)
        {
            var hire = dataAccessLayer.GetHireData(id);
            hire.CzyOplacone = true;
            UpdateHire(hire);

            return RedirectToAction("HireDetails", new { id = hire.HireId });
        }

        public IActionResult changeStatus(int id)
        {
            var hire = dataAccessLayer.GetHireData(id);
            //oczekuje -> w trakcie -> zakonczony --->usuniety
            if (hire.StatusWypozyczenia == "w trakcie") hire.StatusWypozyczenia = "zakonczony";
            if (hire.StatusWypozyczenia == "oczekuje") hire.StatusWypozyczenia = "w trakcie";

            UpdateHire(hire);

            return RedirectToAction("HireDetails", new { id = hire.HireId });
        }

        public IActionResult refuse(int id)
        {
            dataAccessLayer.DeleteHire(id);
            ViewBag.Message = "zrezygnowano";

            return View("Index");
        }

        public IActionResult delete(int id)
        {
            var hire = dataAccessLayer.GetHireData(id);
            hire.StatusWypozyczenia = "usuniety";

            UpdateHire(hire);

            return RedirectToAction("HireDetails", new { id = hire.HireId });
        }

        public IActionResult HireList()
        {
            var hires = dataAccessLayer.GetAllHires();
            List<HireListDetails> hld = new List<HireListDetails>();
            foreach (Hire item in hires)
            {
                HireListDetails tmp = new HireListDetails();
                tmp.HireId = item.HireId;
                tmp.DataWynajmu = item.DataWynajmu;
                tmp.DataZakonczeniaWynajmu = item.DataZakonczeniaWynajmu;
                Cars car = dataAccessLayer.GetCarData(item.CarId);
                Users user = dataAccessLayer.GetUserData(item.UserId);
                tmp.CarName = car.Marka + " " + car.Model;
                tmp.UserName = user.Imie + " " + user.Nazwisko;

                hld.Add(tmp);
            }

            return View(hld);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CarsList()
        {
            var cars = dataAccessLayer.GetAllCars();
            return View(cars);
        }

        public IActionResult Hire(int id)
        {
            ViewBag.CarToHire = dataAccessLayer.GetCarData(id);
            var car = dataAccessLayer.GetCarData(id);
            ViewBag.carToHireModel = car.Model;
            ViewBag.carToHireYearbook = car.Rocznik;
            ViewBag.carToHirePrice = car.CenaZaGodzine;
            ViewBag.carToHireIsAvailability = car.Dostepnosc;

            var hires = dataAccessLayer.GetHireDataByCar(id);

            return View(hires);
        }

        public IActionResult AddUser()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [Route("Home/api/User/Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            ViewBag.Message = "Wylogowano";

            return View("Index");
        }

        [HttpPost]
        [Route("Home/api/User/Add")]
        public IActionResult CreateUser(Users user)
        {
            if (HttpContext.Session.GetString("userEmail") == null)
            {
                user.OpcjeZarzadzania = false;
            }
            else
            {
                if (HttpContext.Session.GetString("userOpcjeZarzadzania") == "admin")
                {
                    user.OpcjeZarzadzania = true;
                }
                else
                {
                    user.OpcjeZarzadzania = false;
                }
            }
            if (user.Haslo != user.PotwierdzHaslo)
            {
                ViewBag.Message = "Hasła się różnią";
                return View("AddUser");
            }
            if (!IsMailValid(user.Email))
            {
                ViewBag.Message = "Mail niepoprawny";
                return View("AddUser");
            }
            bool isOK = dataAccessLayer.validateEmailAvailability(user.Email);
            if (isOK == false)
            {
                ViewBag.Message = "Email jest już w bazie";
                return View("AddUser");
            }
            AddUserdb(user);
            ViewBag.Message = "Dodano użytkownika";
            return View("Index");
        }

        [HttpPost]
        [Route("Home/api/User/Login")]
        public IActionResult CreateSession(Users user)
        {
            var login = dataAccessLayer.getVerificatedUser(user);
            if (login == null)
            {
                ViewBag.Message = "Nieprawidłowe hasło lub mail";
                return RedirectToAction("Login");
            }
            else
            {
                HttpContext.Session.SetString("userEmail", login.Email);
                HttpContext.Session.SetString("userImie", login.Imie);
                HttpContext.Session.SetString("userNazwisko", login.Nazwisko);
                if (login.OpcjeZarzadzania == true)
                {
                    HttpContext.Session.SetString("userOpcjeZarzadzania", "admin");
                }
                else
                {
                    HttpContext.Session.SetString("userOpcjeZarzadzania", "klient");
                }
                ViewBag.Message = "Zalogowano";
            }

            return View("Index");
        }

        public bool checkHireDateAvailability(HireDate hd)
        {
            if (hd.DataWynajmu > hd.DataZakonczeniaWynajmu)
            {
                TempData["Message"] = "Data wynajmu musi być przed zakończeniem";
                return false;
            }
            if (hd.DataWynajmu < DateTime.Now)
            {
                TempData["Message"] = "Data wynajmu nieprawidłowa";
                return false;
            }
            var hire = dataAccessLayer.GetHireDataByCar((hd.CarID));
            foreach (Hire h in hire)
            {
                if (hd.DataWynajmu > h.DataZakonczeniaWynajmu || hd.DataZakonczeniaWynajmu < h.DataWynajmu)
                {
                    continue;
                }
                else
                {
                    TempData["Message"] = "Samochód niedostępny w podanym terminie";
                    return false;
                }
            }

            return true;
        }

        [HttpPost]
        public IActionResult CreateHire(HireDate hireDate)
        {
            Hire hire = new Hire();
            Cars carToHire = dataAccessLayer.GetCarData((hireDate.CarID));

            if (carToHire.Dostepnosc == true)
            {
                if (!checkHireDateAvailability(hireDate))
                {
                    return RedirectToAction("Hire", new { id = carToHire.CarId }); // View("Hire");
                }

                hire.DataWynajmu = hireDate.DataWynajmu;
                hire.DataZakonczeniaWynajmu = hireDate.DataZakonczeniaWynajmu;
                hire.CarId = (hireDate.CarID);
                hire.UserId = dataAccessLayer.getUserIdbyEmail(HttpContext.Session.GetString("userEmail"));
                hire.CenaWynajmu = (hire.DataZakonczeniaWynajmu - hire.DataWynajmu).Days * carToHire.CenaZaGodzine;
                hire.StatusWypozyczenia = "oczekuje";

               // dataAccessLayer.AddHire(hire, HubContext);
               AddHire(hire);
                return View(hire);
            }
            else
            {
                TempData["Message"] = "Samochód niedostępny w podanym terminie";
            }
            return View();
        }

        [HttpGet]
        [Route("api/GetAllHires")]
        public string GetAllHires()
        {
            var listOfHires = dataAccessLayer.GetAllHires();
            string json = JsonConvert.SerializeObject(listOfHires);

            return json;
        }

        [HttpGet]
        [Route("api/GetHire/{id}")]
        public string GetHire(int id)
        {
            var hire = dataAccessLayer.GetHireData(id);
            string json = JsonConvert.SerializeObject(hire);

            return json;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        // FUNCTIONS TO COMMUNICATE WITH QUEUE

        private static string object_type = "";
        private static string order_type = "";

        // Convert an object to a byte array
        private static byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        public static async void DoWork(Object obj)
        {
            try
            {
                var factory = new ConnectionFactory()
                {
                    UserName = "guest",
                    Password = "guest",
                    HostName = "localhost",
                    VirtualHost = "/"
                };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("orders_queue", false, false, false, null);
                    //prepare object to send
                    var objToSend = ObjectToByteArray(obj);
                    //prepare header to send
                    IBasicProperties properties = channel.CreateBasicProperties();
                    properties.Headers = new Dictionary<string, object>();
                    properties.Headers.Add("object_type", object_type);
                    properties.Headers.Add("order_type", order_type);

                    // consume response from consumer
                    string replyQueueName = channel.QueueDeclare().QueueName;
                    QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume(replyQueueName, true, consumer);

                    // required for response
                    properties.ReplyTo = replyQueueName;
                    var corrId = Guid.NewGuid().ToString();
                    properties.CorrelationId = corrId;

                    channel.BasicPublish("", "orders_queue", properties, objToSend);

                    // wait for response
                    while (true)
                    {
                        var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                        if (ea.BasicProperties.CorrelationId == corrId)
                        {
                            // do something with responce
                                await HubContext.Clients.All.SendAsync("ReceiveMessage", "gfda", "aaa");
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        //post new user 
        public int AddUserdb(Users user)
        {
            object_type = "User";
            order_type = "AddUser";
            Thread thread1 = new Thread(DoWork);
            thread1.Start(user);

            return 1;
        }
        //post new hire 
        public int AddHire(Hire hire)
        {
            object_type = "Hire";
            order_type = "AddHire";
            Thread thread1 = new Thread(DoWork);
            thread1.Start(hire);

            return 1;
        }
        //update hire 
        public int UpdateHire(Hire hire)
        {
            object_type = "Hire";
            order_type = "UpdateHire";
            Thread thread1 = new Thread(DoWork);
            thread1.Start(hire);

            return 1;
        }
    }
}
