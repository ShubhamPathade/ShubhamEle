using Project.Core.Domain.Cities;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Traders
{
    public class Trader:BaseEntity
    {
        public string TraderName { get; set; }    
        public string ShopName { get; set; }
        public string Description { get; set; } 
        public string MobileNumber { get; set; } 
        public string AlternateMobileNumber { get; set; } 
        public string EmailAddress { get; set; }    
        public string Address { get; set; } 
        public long? CityId { get; set; }
        public long? StateId { get; set; }
        public State State { get; set; }
        public City City { get; set; }  
    }
}
