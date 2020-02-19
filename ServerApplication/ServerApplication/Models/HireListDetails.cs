using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApplication.Models
{
    public class HireListDetails
    {
        public int HireId { get; set; }
        public DateTime DataWynajmu { get; set; }
        public DateTime DataZakonczeniaWynajmu { get; set; }
        public string UserName { get; set; }
        public string CarName { get; set; }
    }
}
