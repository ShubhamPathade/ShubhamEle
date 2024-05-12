using Project.Core.Domain.Cities;
using Project.Core.Domain.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Electricians
{
    public class Electrician:BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AlternateMobileNumber { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }
        public string LivingAddress { get; set; }
        public long ZipCode { get; set; }
        public string FCMToken { get; set; }
        public State State { get; set; }
        public City City { get; set; }
    }
}
