using System.ComponentModel.DataAnnotations;

namespace Project.Web.Models.Users
{
    public class LoginModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]

        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
