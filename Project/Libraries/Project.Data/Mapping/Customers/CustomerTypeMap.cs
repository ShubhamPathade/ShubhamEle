using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Customers;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Mapping.Customers
{
    public class CustomerTypeMap: ProjectEntityTypeConfiguration<CustomerType>
    {
        public override void Configure(EntityTypeBuilder<CustomerType> builder)
        {
            builder.ToTable(nameof(CustomerType));
            builder.HasKey(type => type.Id);
            builder.Property(type => type.Type).HasMaxLength(100);
            base.Configure(builder);
        }
    }
}
