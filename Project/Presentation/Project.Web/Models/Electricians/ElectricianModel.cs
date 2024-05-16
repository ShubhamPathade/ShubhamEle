using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.Domain.Common;
using System.Collections.Generic;

namespace Project.Web.Models.Electricians
{
    public class ElectricianModel:BaseEntityModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AlternateMobileNumber { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }
        public string LivingAddress { get; set; }
        public long ZipCode { get; set; }
        public string FCMToken { get; set; }
        public IEnumerable<SelectListItem> StateDropDown { get; set; }
    }
}
