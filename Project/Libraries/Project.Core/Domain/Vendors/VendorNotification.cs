using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Core.Domain.Vendors
{
    public class VendorNotification : BaseEntity
    {
        public long VendorId { get; set; }
        public string OrderNo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
        public bool IsAllNotificationRead { get; set; }
        public bool IsNotificationRead { get; set; }

        public Vendor  Vendor { get; set; }
    }
}
