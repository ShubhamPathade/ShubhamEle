namespace Project.Core.Domain.Vendors
{
    public class VehicleType : BaseEntity
    {
        #region Properties
        public string VehicleTypeName { get; set; }
        public string VehicleTypeImagePath { get; set; }
        public decimal CapacityInTon { get; set; }
        public decimal CapacityOfTravelling { get; set; }
        public int Rank { get; set; }

        #endregion
    }
}
