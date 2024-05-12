using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Cities
{
    public class City:BaseEntity
    {
        public string Name { get;set; }
        public long StateId { get; set; }
        public State State { get; set; }    
    }
}
