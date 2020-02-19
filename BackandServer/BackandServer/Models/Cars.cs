using System;
using System.Collections.Generic;

namespace BackandServer.Models
{
    [Serializable]
    public partial class Cars
    {
        public Cars()
        {
            Hire = new HashSet<Hire>();
        }

        public int CarId { get; set; }
        public int LiczbaDrzwi { get; set; }
        public string Rocznik { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public int CenaZaGodzine { get; set; }
        public bool Dostepnosc { get; set; }

        public virtual ICollection<Hire> Hire { get; set; }
    }
}
