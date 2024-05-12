using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Customers
{
   public class CustomerVerifyOTP : BaseEntity
    {
        #region Properties

        public string CompanyName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerContactNo { get; set; }
        public string CustomerAddress { get; set; }
        public string ApiToken { get; set; }
        public long CompanyId { get; set; }

        public long UserId { get; set; }
        #endregion
    }
}
