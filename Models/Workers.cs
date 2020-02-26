using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;



namespace WebApplication3.Models
{
    public class Workers
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string gender { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string position { get; set; }
        public string status { get; set; }
        //[DisplayName("Upload File")]
        public string picturePath { get; set; }
        public Nullable<int> Employee { get; set; }

        public virtual Employee employee { get; set; }


        //public HttpPostedFileHelper PictureFile { get; set; }
    }
}
