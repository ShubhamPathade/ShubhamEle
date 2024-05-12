using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Users;

namespace Project.Data.Mapping.Users
{
    public class UserMap : ProjectEntityTypeConfiguration<User>
    {
        #region Methods

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(user => user.Id);

            builder.Property(user => user.UserName).HasMaxLength(1000);
            builder.Property(user => user.MobileNo).HasMaxLength(100);
            builder.Property(user => user.Email).HasMaxLength(256);
            builder.Property(user => user.Password).HasMaxLength(100);
            builder.Property(user => user.OTP).HasMaxLength(6);
            builder.Property(user => user.DeviceToken).HasMaxLength(1000);

            base.Configure(builder);
        }

        #endregion
    }
}
