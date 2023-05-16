using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => new
            {
                r.SeatFK,
                r.PassengerFK,
                r.DateReservation

            });

            builder.HasOne(t => t.Seat)
               .WithMany(s => s.Reservations)
               .HasForeignKey(t => t.SeatFK);

            builder.HasOne(t => t.Passenger)
              .WithMany(p => p.Reservations)
              .HasForeignKey(t => t.PassengerFK);
        }
    }
}
