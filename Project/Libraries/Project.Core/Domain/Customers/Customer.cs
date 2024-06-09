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
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CustomerEmail { get; set; }
        public string WhatsAppNumber { get; set; }
        public string MobileNumber { get; set; }
        public string CustomerPhoto { get; set; }
        public string CustomerAddress { get; set; }
        public bool WhatsappNotificationStatus { get; set; }
        public long Status { get; set; }
        public long? CustomerTypeId { get; set; }
        public  CustomerType CustomerStatus { get; set; }

        #endregion
    }
}
