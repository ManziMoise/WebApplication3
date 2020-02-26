using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Student
    {
        public int id { get; set; }
        public String name { get; set; }
        public String marks { get; set; }

        //[Display(Name = "Faculty Name")]
        public int ? Faculty { get; set; }

        //[ForeignKey("facultyId")]
        public virtual Faculty faculty { get; set; }
    }
}
