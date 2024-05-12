using Project.Core.Domain.Customers;
using Project.Core.Domain.Managers;
using System.Collections.Generic;

namespace Project.Core.Domain.Users
{
    public class User : BaseEntity
    {
        #region Properties
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }
        public string DeviceToken { get; set; }

        public  ICollection<UserRoleMapping> UserRoles{ get; set; }

        #endregion
    }
}
