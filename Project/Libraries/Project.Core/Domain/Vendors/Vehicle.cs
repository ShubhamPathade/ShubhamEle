namespace Project.Core.Domain.Vendors
{
    public class Vehicle : BaseEntity
    {
        #region Properties
        public long? VendorId { get; set; }
        public long? VehicleTypeId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleCapacity { get; set; }
        public string VehicleRegNo { get; set; }
        public string VehicleImagePath { get; set; }
        public string RCImagePath { get; set; }
        public string RCValidity { get; set; }
        public string InsuranceImagePath { get; set; }
        public string InsuranceValidity { get; set; }
        public string PucImagePath { get; set; }
        public string PucValidity { get; set; }
        public string PermitImagePath { get; set; }
        public string PermitValidity { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsAllowAdvertisements { get; set; }
        //public virtual Vendor Vendor { get; set; }
        public virtual VehicleType VehicleType { get; set; }

        #endregion
    }
}
