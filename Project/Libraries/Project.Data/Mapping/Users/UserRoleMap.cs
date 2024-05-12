using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Users;

namespace Project.Data.Mapping.Users
{
    public class UserRoleMap : ProjectEntityTypeConfiguration<UserRoleMapping>
    {
        #region Methods

        public override void Configure(EntityTypeBuilder<UserRoleMapping> builder)
        {
            builder.ToTable(nameof(UserRoleMapping));
            builder.HasKey(userRoleMap => userRoleMap.Id);

            builder.HasOne(userRoleMap => userRoleMap.User)
                .WithMany(user => user.UserRoles)
                .HasForeignKey(userRoleMap => userRoleMap.UserId);

            builder.HasOne(userRoleMap => userRoleMap.Role)
                .WithMany()
                .HasForeignKey(userRoleMap => userRoleMap.RoleId);

            base.Configure(builder);
        }

        #endregion
    }
}
