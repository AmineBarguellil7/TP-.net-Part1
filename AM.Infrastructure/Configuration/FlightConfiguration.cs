using AM.Application.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("MyFlight");
           builder.HasKey(f => f.FlightId);
            builder.HasMany(flight => flight.Passengers).WithMany(p=>p.ListFlight).UsingEntity(
                p=>p.ToTable("TablePassengersFlights"));
            builder.HasOne(f=>f.Plane).WithMany(p=>p.Flights).HasForeignKey(f => f.PlaneId).
                OnDelete(DeleteBehavior.SetNull);
        }
    }
}
