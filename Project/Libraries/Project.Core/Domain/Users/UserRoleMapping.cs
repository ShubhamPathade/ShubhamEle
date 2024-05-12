namespace Project.Core.Domain.Users
{
    public class UserRoleMapping : BaseEntity
    {
        #region Properties
        public long UserId { get; set; }
        public long RoleId { get; set; }

        public  User User { get; set; }
        public  Role Role { get; set; }

        #endregion
    }
}
