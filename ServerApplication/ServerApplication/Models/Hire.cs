using System;
using System.Collections.Generic;

namespace ServerApplication.Models
{
    [Serializable]
    public partial class Hire
    {
        public int HireId { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public DateTime DataWynajmu { get; set; }
        public DateTime DataZakonczeniaWynajmu { get; set; }
        public int CenaWynajmu { get; set; }
        public bool? CzyOplacone { get; set; }
        public string StatusWypozyczenia { get; set; }

        public virtual Cars Car { get; set; }
        public virtual Users User { get; set; }
    }
}
