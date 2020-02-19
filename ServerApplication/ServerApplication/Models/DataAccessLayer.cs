using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ServerApplication.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace ServerApplication.Models
{
    public class DataAccessLayer
    {
        carRentalDBContext db = new carRentalDBContext();

        public bool validateEmailAvailability(string email)
        {
            List<Users> users = new List<Users>();
            users = db.Users.ToList();
            foreach (Users user in users)
            {
                if (user.Email == email) return false;
            }

            return true;
        }

        //get all cars
        public IEnumerable<Cars> GetAllCars()
        {
            try
            {
                return db.Cars.ToList();
            }
            catch
            {
                throw;
            }
        }
        //get car by id
        public Cars GetCarData(int id)
        {
            try
            {
                Cars car = db.Cars.Find(id);
                return car;
            }
            catch
            {
                throw;
            }
        }
        //get all hires 
        public List<Hire> GetAllHires()
        {
            try
            {
                return db.Hire.ToList();
            }
            catch
            {
                throw;
            }
        }
        //get hire by id
        public Hire GetHireData(int id)
        {
            try
            {
                Hire hire = db.Hire.Find(id);
                return hire;
            }
            catch
            {
                throw;
            }
        }
        //get hire by Car
        public IEnumerable<Hire> GetHireDataByCar(int carID)
        {
            try
            {
                List<Hire> hire = new List<Hire>();
                hire = db.Hire.Where(s => s.CarId == carID).ToList();
                return hire;
            }
            catch
            {
                throw;
            }
        }
        //get user (verification)
        public Users getVerificatedUser(Users user)
        {
            var usr = new Users();
            try
            {
                usr = db.Users.Single(u => u.Email == user.Email && u.Haslo == user.Haslo);
            }
            catch (System.InvalidOperationException e)
            {
                usr = null;
            }
            return usr;
        }
        //get User Id by Email
        public int getUserIdbyEmail(string email)
        {
            var usr = new Users();
            try
            {
                usr = db.Users.Single(u => u.Email == email);
            }
            catch (System.InvalidOperationException e)
            {
                usr = null;
            }
            return usr.UserId;
        }
        //get user by id
        public Users GetUserData(int id)
        {
            try
            {
                Users user = db.Users.Find(id);
                return user;
            }
            catch
            {
                throw;
            }
        }

        //get all users


        // FUNCTIONS TO COMMUNICATE WITH QUEUE

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

        //update car row
        public int UpdateCar(Cars car)
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
                    var objToSend = ObjectToByteArray(car);
                    //prepare header to send
                    IBasicProperties properties = channel.CreateBasicProperties();
                    properties.Headers = new Dictionary<string, object>();
                    properties.Headers.Add("object_type", "Car");
                    properties.Headers.Add("order_type", "UpdateCar");

                    channel.BasicPublish("", "orders_queue", properties, objToSend);
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //update hire row
        //public int UpdateHire(Hire hire)
        //{
        //    try
        //    {
        //        var factory = new ConnectionFactory()
        //        {
        //            UserName = "guest",
        //            Password = "guest",
        //            HostName = "localhost",
        //            VirtualHost = "/"
        //        };
        //        using (var connection = factory.CreateConnection())
        //        using (var channel = connection.CreateModel())
        //        {
        //            channel.QueueDeclare("orders_queue", false, false, false, null);
        //            //prepare object to send
        //            var objToSend = ObjectToByteArray(hire);
        //            //prepare header to send
        //            IBasicProperties properties = channel.CreateBasicProperties();
        //            properties.Headers = new Dictionary<string, object>();
        //            properties.Headers.Add("object_type", "Hire");
        //            properties.Headers.Add("order_type", "UpdateHire");

        //            channel.BasicPublish("", "orders_queue", properties, objToSend);
        //        }
        //        return 1;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        //post new user  
        //public int AddUser(Users user)
        //{
        //    if (validateEmailAvailability(user.Email) == false)
        //    {
        //        return -1;
        //    }
        //    try
        //    {
        //        var factory = new ConnectionFactory()
        //        {
        //            UserName = "guest",
        //            Password = "guest",
        //            HostName = "localhost",
        //            VirtualHost = "/"
        //        };
        //        using (var connection = factory.CreateConnection())
        //        using (var channel = connection.CreateModel())
        //        {
        //            channel.QueueDeclare("orders_queue", false, false, false, null);
        //            //prepare object to send
        //            var objToSend = ObjectToByteArray(user);
        //            //prepare header to send
        //            IBasicProperties properties = channel.CreateBasicProperties();
        //            properties.Headers = new Dictionary<string, object>();
        //            properties.Headers.Add("object_type", "User");
        //            properties.Headers.Add("order_type", "AddUser");

        //            channel.BasicPublish("", "orders_queue", properties, objToSend);
        //        }
        //        return 1;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //public static async void DoWork(Object obj)
        //{
        //    try
        //    {
        //        var factory = new ConnectionFactory()
        //        {
        //            UserName = "guest",
        //            Password = "guest",
        //            HostName = "localhost",
        //            VirtualHost = "/"
        //        };
        //        using (var connection = factory.CreateConnection())
        //        using (var channel = connection.CreateModel())
        //        {
        //            channel.QueueDeclare("orders_queue", false, false, false, null);
        //            //prepare object to send
        //            var objToSend = ObjectToByteArray(obj);
        //            //prepare header to send
        //            IBasicProperties properties = channel.CreateBasicProperties();
        //            properties.Headers = new Dictionary<string, object>();
        //            properties.Headers.Add("object_type", "Hire");
        //            properties.Headers.Add("order_type", "AddHire");

        //            // consume response from consumer
        //            string replyQueueName = channel.QueueDeclare().QueueName;
        //            QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);
        //            channel.BasicConsume(replyQueueName, true, consumer);

        //            // required for response
        //            properties.ReplyTo = replyQueueName;
        //            var corrId = Guid.NewGuid().ToString();
        //            properties.CorrelationId = corrId;

        //            channel.BasicPublish("", "orders_queue", properties, objToSend);

        //            // wait for response
        //            while (true)
        //            {
        //                var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
        //                if (ea.BasicProperties.CorrelationId == corrId)
        //                {
        //                    // do something with responce
        //                //    await HubContext.Clients.All.SendAsync("ReceiveMessage", "gfda", "aaa");
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        //post new hire 
        //public int AddHire(Hire hire, IHubContext<ListHub> hubcontext)
        //{
        //    Thread thread1 = new Thread(DoWork);
        //    thread1.Start(hire);

        //    return 1;
        //}
        //delete hire
        public int DeleteHire(int id)
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
                    var objToSend = ObjectToByteArray(id);
                    //prepare header to send
                    IBasicProperties properties = channel.CreateBasicProperties();
                    properties.Headers = new Dictionary<string, object>();
                    properties.Headers.Add("object_type", "Hire");
                    properties.Headers.Add("order_type", "DeleteHire");

                    channel.BasicPublish("", "orders_queue", properties, objToSend);
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
