using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Customers
{
     public  class CustomerRegistrationNotificationTemplateModel : BaseModel
    {
        #region Properties
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerNo { get; set; }

        public string CustomerAddress { get; set; }

        public string CompanyName { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }



        #endregion
    }
}
