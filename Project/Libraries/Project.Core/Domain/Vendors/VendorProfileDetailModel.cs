using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Vendors
{
    public   class VendorProfileDetailModel:BaseModel
    {
        public string VendorCompanyName { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonNumber { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string TotalRoutes { get; set; }
        public string OfficeAddress { get; set; }
        public string ProfileImage { get; set; }
        public decimal? Rating { get; set; }
        public decimal? TotalRatingCount { get; set; }

    }
}
