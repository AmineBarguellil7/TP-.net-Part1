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
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(f => f.fullName, h =>
            {
                h.Property(f => f.FirstName).HasColumnName("first_name").HasMaxLength(20).HasColumnType("varchar");
                h.Property(f => f.LastName).HasColumnName("last_name").HasMaxLength(20).HasColumnType("varchar");
            });
            builder.HasDiscriminator<Char>("Type")
                .HasValue<Passenger>('A')
                .HasValue<Staff>('B')
                .HasValue<Traveller>('C');
        }
    }
}
