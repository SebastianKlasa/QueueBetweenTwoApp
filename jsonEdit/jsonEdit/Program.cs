using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace jsonEdit
{
    public class CarOutput
    {
        public int carID;
        public int  liczba_drzwi;
        public string rocznik;
        public string marka;
        public string model;
        public string nadwozie;
        public int cena_za_godzine;
        public bool dostepnosc;
    }

    public class CarInput
    {
        public int id;
        public string created;
        public string modified;
        public string trim;
        public int num_doors;
        public string year;
        public string drivetype_desc;
        public string make_name;
        public string model_name;
        public string drivetrain;
        public string bodytype;
    }

    /*
     "id": "1",
        "created": "2013-10-04 13:00:23",
        "modified": "2016-12-12 18:24:41",
        "trim": "528i",
        "num_doors": "4",
        "year": "1999",
        "drivetype_desc": "RWD",
        "make_name": "BMW",
        "model_name": "5-series",
        "drivetrain": "RWD",
        "bodytype": "sedan"
         */

    class Program
    {
        static void Main(string[] args)
        {
            List<CarInput> items;
            using (StreamReader r = new StreamReader("cars.json"))
            {
                string json22 = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<CarInput>>(json22);
            }
            int i = 0;
            List<CarOutput> _data = new List<CarOutput>();

            foreach (CarInput ci in items)
            {
                if (i % 100 == 0)
                {
                    CarOutput co = new CarOutput();
                    co.carID = ci.id;
                    co.liczba_drzwi = ci.num_doors;
                    co.rocznik = ci.year;
                    co.marka = ci.make_name;
                    co.model = ci.model_name;
                    co.nadwozie = ci.bodytype;

                    Random random = new Random();
                    int randomNumber = random.Next(30, 100);
                    co.cena_za_godzine = randomNumber;
                    co.dostepnosc = true;

                    _data.Add(co);
                }
                i++;
            }
            string json = JsonConvert.SerializeObject(_data.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"E:\KSRprojekt\jsonEdit\jsonEdit\bin\Debug\netcoreapp2.2\data.json", json);


            Console.WriteLine("Hello World!");
        }
    }
}
