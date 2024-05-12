using Project.Core.Domain.Companies;
using Project.Core.Domain.Status;
using Project.Core.Domain.Users;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Project.Core.Domain.Customers
{
    public class Customer : BaseEntity
    {
        #region Properties 
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerContactNo { get; set; }
        public string CustomerPhoto { get; set; }
        public string CustomerAddress { get; set; }
        public string DeviceToken { get; set; }
        public string ApiToken { get; set; }
        public string Password { get; set; }
        public string Otp { get; set; }
        public bool PushNotificationStatus { get; set; }
        public bool WhatsappNotificationStatus { get; set; }
        public long Status { get; set; }
        public Nullable<long> CustomerTypeId { get; set; }
        public bool IsLead { get; set; }
        public virtual CustomerStatus CustomerStatus { get; set; }
       public virtual CustomerType CustomerType { get; set; }
        public virtual ICollection<CustomerCompanyMapping>  CustomerCompany { get; set; }

        #endregion
    }
}
