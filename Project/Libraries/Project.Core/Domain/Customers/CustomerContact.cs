using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Customers
{
   public class CustomerContact : BaseEntity
    {
        #region Properties
        public string CustomerName { get; set; }
        public string CustomerContactNo { get; set; }
        public string CustomerEmail { get; set; }

        #endregion
    }
}
