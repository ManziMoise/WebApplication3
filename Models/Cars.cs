using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Cars
    {
        public int id { get; set; }
        public string PlateNo { get; set; }

        public string model { get; set; }
        public string type { get; set; }
        public string color { get; set; }
        public DateTime madeDate{get; set;}
        public DateTime boughtDate { get; set; }
        public string status { get; set; }
    }
}
