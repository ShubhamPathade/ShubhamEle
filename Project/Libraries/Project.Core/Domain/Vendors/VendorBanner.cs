namespace Project.Core.Domain.Vendors
{
    public class VendorBanner : BaseEntity
    {
        public string BannerImage { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
    }
}
