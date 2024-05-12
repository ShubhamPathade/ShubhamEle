using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Vendors
{
  public class VenderRegistrationNotificationTemplateModel : BaseEntity
    {
        public string VendorCompanyName { get; set; }

        public string AadharNumber { get; set; }

        public string PanNumber { get; set; }
        public string OfficeAddress { get; set; }

        public string ContactPersonName { get; set; }
        public string ContactPersonNumber { get; set; }
        public string ContactPersonEmail { get; set; }
        public string BankAcNumber { get; set; }
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public string UserName { get; set; }

        public string UserEmail { get; set; }

    }
}
