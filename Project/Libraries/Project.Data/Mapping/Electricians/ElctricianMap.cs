using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Electricians;

namespace Project.Data.Mapping.Electricians
{
    public class ElctricianMap: ProjectEntityTypeConfiguration<Electrician>
    {
        public override void Configure(EntityTypeBuilder<Electrician> builder)
        {
            builder.ToTable(nameof(Electrician));
            builder.HasKey(electrcian => electrcian.Id);
            builder.Property(electrcian => electrcian.FirstName).HasMaxLength(50);
            builder.Property(electrcian => electrcian.MiddleName).HasMaxLength(50);
            builder.Property(electrcian => electrcian.LastName).HasMaxLength(50);
            builder.Property(electrcian => electrcian.MobileNumber).HasMaxLength(20);
            builder.Property(electrcian => electrcian.AlternateMobileNumber).HasMaxLength(20);
            builder.Property(electrcian => electrcian.EmailAddress).HasMaxLength(100);
            builder.Property(electrcian => electrcian.ZipCode).HasMaxLength(10);
            builder.Property(electrcian => electrcian.FCMToken).HasMaxLength(1000);

            builder.HasOne(electrician => electrician.City)
                .WithMany()
                .HasForeignKey(electrician => electrician.CityId)
                .IsRequired(false);

            builder.HasOne(electrician => electrician.State)
                .WithMany()
                .HasForeignKey(electrician => electrician.StateId)
                .IsRequired(false);

            base.Configure(builder);
        }
    }
}
