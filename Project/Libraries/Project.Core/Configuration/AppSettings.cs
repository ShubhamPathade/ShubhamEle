namespace Project.Core.Configuration
{
    public class AppSettings
    {
        #region Properties

        /// <summary>
        /// Get or set connection string.
        /// </summary>
        public string ConnectionString { get; set; }
        public string IntugineUserName { get; set; }
        public string IntuginePassword { get; set; }
        public string AadharApiToken { get; set; }
        public string SMSApiToken { get; set; }
        public string WebBaseUrl { get; set; }
        public string TruckBhejoEmail { get; set; }
        public string SuperAdminEmail { get; set; }
        public string GSTApiToken { get; set; }
        public string FreightTigerToken { get; set; }
        public decimal DiscountAmount { get; set; }

        #endregion
    }
}
