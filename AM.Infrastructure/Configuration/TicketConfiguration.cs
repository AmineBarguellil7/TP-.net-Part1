using AM.Application.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.PassengerFK, t.FlightFK });
            builder.HasOne(t=>t.passenger).WithMany(p=>p.tickets).HasForeignKey(t=>t.PassengerFK);
            builder.HasOne(t=>t.flight).WithMany(p=>p.Tickets).HasForeignKey(t=>t.FlightFK);
        }
    }
}
