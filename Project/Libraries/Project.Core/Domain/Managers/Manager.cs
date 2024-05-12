using Project.Core.Domain.Companies;
using Project.Core.Domain.Users;

namespace Project.Core.Domain.Managers
{
    public class Manager : BaseEntity
    {
        #region Properties

        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string PhotoPath { get; set; }
        public long? ManagerTypeId { get; set; }
        public string DeviceToken { get; set; }
        public string ApiToken { get; set; }
        public string Password { get; set; }
        public string Otp { get; set; }
        public bool HavingPushNotificationStatus { get; set; }

        // public long? UserId { get; set; }

        //public  User User { get; set; }
        public ManagerType ManagerType { get; set; }

        #endregion
    }
}
