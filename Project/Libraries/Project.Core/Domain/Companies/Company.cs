using Project.Core.Domain.Managers;
using System;

namespace Project.Core.Domain.Companies
{
    public class Company : BaseEntity
    {
        #region Properties
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyDiscription { get; set; }
        public DateTime ContractValidityFrom { get; set; }
        public DateTime ContractValidityTo { get; set; }
        public string ContractDocumentPath { get; set; }
        public int NoOfDays { get; set; }
        
        public string QuotationOfWork { get; set; }
        public string Scope { get; set; }
        public DateTime OperationFrom { get; set; }
        public DateTime OperationTo { get; set; }
        public decimal NoOfKms { get; set; }
        public decimal Price { get; set; }
        public decimal PriceOneKm { get; set; }
        public decimal PriceOneHour { get; set; }
        public string Token { get; set; }
        public string SecretKey { get; set; }
        //public long? ManagerId { get; set; }

        public string CompanyLogo { get; set; }
        public string RateDocument { get; set; }

        public string AccountingPersonName { get; set; }
        public string AccountingPersonContactNumber { get; set; }
        public string AccountingPersonEmailID { get; set; }
        public bool IsKYCPending { get; set; }
        public string GSTNo { get; set; }
        public string AadharNumber { get; set; }
        public int? PaymentTermsInDays { get; set; }

        //public Manager Manager { get; set; }

        #endregion
    }
}
