using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Electricians;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Mapping.States
{
    public class StateMap:ProjectEntityTypeConfiguration<State>
    {
        public override void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable(nameof(State));
            builder.HasKey(state => state.Id);
            builder.Property(state => state.Name).HasMaxLength(100);            
            base.Configure(builder);
        }
    }
}
