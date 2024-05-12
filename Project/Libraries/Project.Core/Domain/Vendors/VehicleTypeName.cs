using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Vendors
{
   public class VehicleTypeName :BaseEntity
    {
        #region Properties
        public string TypeName { get; set; }
        public decimal CapacityInTon { get; set; }
        public string VehicleTypeImagePath { get; set; }
        public int Rank { get; set; }


        #endregion
    }
}
