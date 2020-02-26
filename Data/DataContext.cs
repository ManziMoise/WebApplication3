using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
//using WebApplication3.Models.ViewModel;

namespace WebApplication3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : 
            base(options)
        {
                
        }
        public DbSet<Models.Book> books { get; set; }
        public DbSet<Models.Employee> Employee { get; set; }
        public DbSet<Models.SecurityStaff> securityStaffs { get; set; }
        public DbSet<CarReg> CarRegs { get; set; }
        //public DbSet<Models.Workers> Workerss { get; set; }
        public DbSet<Models.Cars> carss { get; set; }

        public DbSet<Models.Material> materials { get; set; }
        public DbSet<Models.KeyReg> keyRegs { get; set; }

        public DbSet<Models.Faculty> facultiess { get; set; }

        public DbSet<Models.Student> students { get; set; }


        //public DbSet<WebApplication3.Models.ViewModel.CarViewModel> CarViewModel { get; set; }

    }
}
