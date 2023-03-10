using AM.Application.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    internal class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plane> builder)
        {
            builder.ToTable("MyPlanes");
            builder.HasKey(p => p.PlaneId);
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");
        }
    }
}
