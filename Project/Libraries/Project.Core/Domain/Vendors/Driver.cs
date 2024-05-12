namespace Project.Core.Domain.Vendors
{
    public class Driver : BaseEntity
    {
        #region Properties 

        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string CityName { get; set; }
        public string DriverImagePath { get; set; }
        public string LicenseNo { get; set; }
        public string DriverLicenceImagePath { get; set; }
        public string LicenceValidity { get; set; }
        public bool IsVerify { get; set; }
        public bool IsAvailable { get; set; }

        #endregion
    }
}
