using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Cities;
using Project.Core.Domain.Traders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Mapping.Traders
{
    public class TraderMap: ProjectEntityTypeConfiguration<Trader>
    {
        public override void Configure(EntityTypeBuilder<Trader> builder)
        {
            builder.ToTable(nameof(Trader));
            builder.HasKey(trader => trader.Id);
            builder.Property(trader => trader.TraderName).HasMaxLength(200);
            builder.Property(trader => trader.ShopName).HasMaxLength(100);
            builder.Property(trader => trader.Description).HasMaxLength(100);
            builder.Property(trader => trader.MobileNumber).HasMaxLength(20);
            builder.Property(trader => trader.AlternateMobileNumber).HasMaxLength(20);
            builder.Property(trader => trader.Address).HasMaxLength(500);

            builder.HasOne(trader => trader.State)
                .WithMany()
                .HasForeignKey(trader => trader.StateId)
                .IsRequired(false);

            builder.HasOne(trader => trader.City)
                .WithMany()
                .HasForeignKey(trader => trader.CityId)
                .IsRequired(false);

            base.Configure(builder);
        }
    }
}
