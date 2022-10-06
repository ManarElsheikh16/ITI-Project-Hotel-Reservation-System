using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    class DataContext:DbContext
    {
        public DataContext() : base("name = Training_ITI")
        {
          
        }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Guset> Guests { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Fedback> Fedbacks { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Booking> booking { get; set; }
    }
}
