using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DarshanHotelWebApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }

        public virtual DbSet<RoomTariff> RoomTariffs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DatabaseContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}