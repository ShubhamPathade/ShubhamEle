using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Customers
{
   public class CustomerNotification : BaseEntity
    {
        public long CustomerId { get; set; }
        public string OrderNo { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public string  Action { get; set; }
        public bool  IsAllNotificationRead { get; set; }
        public bool  IsNotificationRead { get; set; }

        public Customer Customer { get; set; }

    }
}
