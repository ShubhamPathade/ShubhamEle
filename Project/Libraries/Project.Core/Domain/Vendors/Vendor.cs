using Project.Core.Domain.Status;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Core.Domain.Vendors
{
    public class Vendor : BaseEntity
    {
        #region Properties
        public string VendorCompanyName { get; set; }
        public string AadharImagePath { get; set; }
        public string AadharNumber { get; set; }
        public string PanImagePath { get; set; }
        public string TdsImagePath { get; set; }
        public string PanNumber { get; set; }
        public string CancelledChequeImagePath { get; set; }
        public string OfficeAddress { get; set; }
        public long? CityId { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonNumber { get; set; }
        public string ContactPersonEmail { get; set; }
        public string BankAcNumber { get; set; }
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public string FcmToken { get; set; }
        public string APIToken { get; set; }
        public long Status { get; set; }
        public string UpiId { get; set; }
        public string OTP { get; set; }
        public string TBMVendorId { get; set; }
        public string ReferenceNumber { get; set; }
        public bool PushNotificationStatus { get; set; }
        public bool WhatsappNotificationStatus { get; set; }
        public virtual VendorStatus VendorStatus { get; set; }
        public string ProfileImage { get; set; }
        public bool IsDefaultVendor { get; set; }
        public string GSTNo { get; set; }

        //new columns
        public string EstablishmentYear { get; set; }
        public string ZipCode { get; set; }
        public string CityState { get; set; }
        public long? ServiceTypeId { get; set; }
        public long? KycDocumentId { get; set; }
        public string BranchName { get; set; }
        public bool IsTrackingAvailable { get; set; }
        public long? TrackingDevelopedId { get; set; }
        public string OutSourcedContactPersonName { get; set; }
        public string OutSourcedContactPersonMobile { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsProfileCompleted { get; set; }
        #endregion
    }
}
