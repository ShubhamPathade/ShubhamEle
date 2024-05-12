using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Vendors
{
   public class Bids : BaseEntity
    {
        #region Properties

        public long VendorId { get; set; }
        public long? ManagerId { get; set; }
        public long OrderId { get; set; }
        public decimal?  BidAmount { get; set; }
        public decimal?  CommissionAmount { get; set; }
        public decimal?  BidFinalAmount { get; set; }
        public bool?  IsBidWin { get; set; }
        public long? CustomerId { get; set; }
        public bool IsAcceptBid { get; set; }
        public bool IsRejectBid { get; set; }
        public bool IsNewBidAfterReject{ get; set; }
        public bool IsShown { get; set; }
        public bool IsImmediatelyAvailable { get; set; }

        #endregion
    }
}
