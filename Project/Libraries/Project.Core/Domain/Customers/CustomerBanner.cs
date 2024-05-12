namespace Project.Core.Domain.Customers
{
    public class CustomerBanner : BaseEntity
    {
        public string BannerImage { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
    }
}
