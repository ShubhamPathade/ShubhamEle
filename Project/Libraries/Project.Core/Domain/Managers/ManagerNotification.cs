namespace Project.Core.Domain.Managers
{
    public class ManagerNotification : BaseEntity
    {
        public long ManagerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string OrderNo { get; set; }
        public long? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Action { get; set; }
        public bool IsAllNotificationRead { get; set; }
        public bool IsNotificationRead { get; set; }

        public Manager Manager { get; set; }
    }
}
