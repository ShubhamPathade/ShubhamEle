using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Cities;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Mapping.Cities
{
    public class CityMap:ProjectEntityTypeConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable(nameof(City));
            builder.HasKey(city => city.Id);
            builder.Property(city => city.Name).HasMaxLength(100);

            builder.HasOne(city => city.State)
                .WithMany()
                .HasForeignKey(city => city.StateId);

            base.Configure(builder);
        }
    }
}
