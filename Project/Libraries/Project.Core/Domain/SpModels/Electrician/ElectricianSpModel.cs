using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.SpModels.Electrician
{
    public class ElectricianSpModel : BaseModel
    {
        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AlternateMobileNumber { get; set; }
        public long? StateId { get; set; }
        public string StateName { get; set; }
        public long? CityId { get; set; }
        public string CityName { get; set; }
        public string LivingAddress { get; set; }
        public long ZipCode { get; set; }
    }
}
