using Microsoft.EntityFrameworkCore;
using System;
using AM.Application.Core.Domain;
using AM.Infrastructure.Configuration;

namespace AM.Infrastructure
{
    public class AmContext :DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }

        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(localdb)\mssqllocaldb; initial catalog=amineBarguellil; integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    modelBuilder.ApplyConfiguration(new FlightConfiguration());
            //    modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            //    modelBuilder.Entity<Passenger>().Property(f=>f.FirstName).HasColumnName("PassengerName")
            //        .HasMaxLength(50)
            //        .IsRequired()
            //        .HasColumnType("varchar");
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveColumnType("varchar").HaveMaxLength(50);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<Double>().HavePrecision(2,3);  //2 chiffres avant la virgule 3 apres la virgule
        }

    }
}
