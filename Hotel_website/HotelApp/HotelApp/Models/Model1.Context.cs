//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelEntities7 : DbContext
    {
        public HotelEntities7()
            : base("name=HotelEntities7")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Fedbacks> Fedbacks { get; set; }
        public virtual DbSet<Gusets> Gusets { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Staffs> Staffs { get; set; }
    }
}
