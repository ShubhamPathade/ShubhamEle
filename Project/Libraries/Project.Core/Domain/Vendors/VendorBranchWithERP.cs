namespace Project.Core.Domain.Vendors
{
    public class VendorBranchWithERP : BaseEntity
    {
        public long VendorId { get; set; }
        public string BranchName { get; set; }
        public string BranchHeadName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string AltMobileNumber { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string CityState { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Vendor Vendor { get; set; }
    }
}
