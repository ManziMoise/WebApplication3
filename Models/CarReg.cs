using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class CarReg
    {

        public int id { get; set; }
        public DateTime date { get; set; }

        [Display(Name ="Employe Name")]
        public int EmployeeId { get; set; }
        public string plateNo { get; set; }
        public DateTime timein { get; set; }
        public DateTime timeout { get; set; }

        [Display(Name ="security Stufff")]
        public int ? SecurityStaffId { get; set; }
        public string status { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("SecurityStaffId")]
        public virtual SecurityStaff SecurityStaff { get; set; }





        
    }
}
