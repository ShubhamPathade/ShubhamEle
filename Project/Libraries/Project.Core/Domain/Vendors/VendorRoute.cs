using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Vendors
{
    public class VendorRoute : BaseEntity
    {
        #region Properties
        public long VendorId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public decimal? Rate { get; set; }
        public int? SLA { get; set; }

        public Vendor Vendor { get; set; }

        #endregion
    }
}
