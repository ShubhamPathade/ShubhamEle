namespace Project.Core.Domain.Vendors
{
    public class DriverVehicleMapping : BaseEntity
    {
        #region Properties

        public long DriverId { get; set; }
        public long VehicleId { get; set; }

        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }

        public bool IsAvailable { get; set; }

        #endregion
    }
}
