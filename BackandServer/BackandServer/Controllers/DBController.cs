using System;
using ServerApplication.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BackandServer.Controllers
{
    class DBController
    {
        DatabaseModel data = new DatabaseModel();

        public void manage(string orderType, Object obj)
        {
            if (orderType == "DeleteHire")
            {
                data.DeleteHire((int)obj);
                return;
            }
            if (orderType == "AddHire")
            {
                data.AddHire((Hire)obj);
                return;
            }
            if (orderType == "AddUser")
            {
                data.AddUser((Users)obj);
                return;
            }
            if (orderType == "UpdateHire")
            {
                data.UpdateHire((Hire)obj);
                return;
            }
            if (orderType == "UpdateCar")
            {
                data.UpdateCar((Cars)obj);
                return;
            }
            Console.WriteLine("Nie znaleziono polecenia!");
        }

    }

    class DatabaseModel
    {
        carRentalDBContext db = new carRentalDBContext();

        private bool validateEmailAvailability(string email)
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
        public IEnumerable<Hire> GetAllHires()
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


        //update car row
        public int UpdateCar(Cars car)
        {
            try
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //update hire row
        public int UpdateHire(Hire hire)
        {
            try
            {
                db.Entry(hire).State = EntityState.Modified;
                db.SaveChanges();
                db.Entry(hire).State = EntityState.Detached;

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //add new user  
        public int AddUser(Users user)
        {
            if (validateEmailAvailability(user.Email) == false)
            {
                return -1;
            }
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //post new hire 
        public int AddHire(Hire hire)
        {
            try
            {
                db.Hire.Add(hire);
                db.SaveChanges();
                db.Entry(hire).State = EntityState.Detached;
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //delete hire
        public int DeleteHire(int id)
        {
            try
            {
                Hire emp = db.Hire.Find(id);
                db.Hire.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }

}
