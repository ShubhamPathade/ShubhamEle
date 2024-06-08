using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.Web.Models.Electricians
{
    public class ElectricianModel : BaseEntityModel
    {
        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-zA-Z]{1,50}$", ErrorMessage = "Please enter only alphabetic characters with a maximum length of 50.")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[a-zA-Z]{1,50}$", ErrorMessage = "Please enter only alphabetic characters with a maximum length of 50.")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"^[a-zA-Z]{1,50}$", ErrorMessage = "Please enter only alphabetic characters with a maximum length of 50.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^[789]\d{9}$", ErrorMessage = "Please enter a valid 10-digit Indian mobile number.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
        public string EmailAddress { get; set; }

        [RegularExpression(@"^[789]\d{9}$", ErrorMessage = "Please enter a valid 10-digit Indian mobile number.")]
        public string AlternateMobileNumber { get; set; }

        [Required(ErrorMessage = "State is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Selected state is not valid.")]
        public long? StateId { get; set; }
        public string StateName { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Selected city is not valid.")]
        public long? CityId { get; set; }
        public string CityName { get; set; }

        [StringLength(500, ErrorMessage = "The address should not exceed 500 characters.")]
        public string LivingAddress { get; set; }

        [Required(ErrorMessage = "ZIP / PIN code is required")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Please enter a valid 6-digit ZIP / PIN code.")]
        public long ZipCode { get; set; }

        public string FCMToken { get; set; }
        public IEnumerable<SelectListItem> StateDropDown { get; set; }
        public IEnumerable<SelectListItem> CityDropDown { get; set; }
    }
}
