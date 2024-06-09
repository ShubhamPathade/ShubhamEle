using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Customers;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Mapping.Customers
{
    public class CustomerMap: ProjectEntityTypeConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));
            builder.HasKey(customer => customer.Id);
            builder.Property(customer => customer.Name).HasMaxLength(100);
            builder.Property(customer => customer.Name).HasMaxLength(100);
            builder.Property(customer => customer.Name).HasMaxLength(100);
            builder.Property(customer => customer.Name).HasMaxLength(100);
            builder.Property(customer => customer.Name).HasMaxLength(100);
            builder.Property(customer => customer.Name).HasMaxLength(100);
            builder.Property(customer => customer.Name).HasMaxLength(100);
            base.Configure(builder);
        }
    }
}
