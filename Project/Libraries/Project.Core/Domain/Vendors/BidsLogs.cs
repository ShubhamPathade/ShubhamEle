using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Vendors
{
  public  class BidsLogs : BaseEntity
    {
        #region
        public long VendorId { get; set; }
        public long OrderId { get; set; }
        public decimal? BidAmount { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? BidFinalAmount { get; set; }
        public long? CustomerId { get; set; }
        public bool IsAcceptBid { get; set; }
        public bool IsRejectBid { get; set; }
        #endregion
    }
}
