using System;
using DB.Tables;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Host=localhost;Port=5432;Database=local;Username=postgres;Password=250521");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Airplane> Airplanes { set; get; }
        public virtual DbSet<Flight> Flights { set; get; }
        public virtual DbSet<Pilot> Pilots { set; get; }
        public virtual DbSet<Route> Routes { set; get; }
        public virtual DbSet<Ticket> Tickets { set; get; }
    }
}
