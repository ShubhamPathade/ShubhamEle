using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Domain.Users;

namespace Project.Data.Mapping.Users
{
    public class RoleMap : ProjectEntityTypeConfiguration<Role>
    {
        #region Methods

        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(nameof(Role));
            builder.HasKey(role => role.Id);

            builder.Property(role => role.RoleName).HasMaxLength(500);

            base.Configure(builder);
        }

        #endregion
    }
}
