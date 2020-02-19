using System;
using System.Collections.Generic;

namespace ServerApplication.Models
{
    [Serializable]
    public partial class Users
    {
        public Users()
        {
            Hire = new HashSet<Hire>();
        }

        public int UserId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Haslo { get; set; }
        public string PotwierdzHaslo { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public bool? OpcjeZarzadzania { get; set; }

        public virtual ICollection<Hire> Hire { get; set; }
    }
}
