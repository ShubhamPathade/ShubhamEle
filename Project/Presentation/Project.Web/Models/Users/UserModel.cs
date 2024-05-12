using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.Domain.Users;
using System.Collections.Generic;

namespace Project.Web.Models.Users
{
    public class UserModel : BaseEntityModel
    {
        #region Constructor
        public UserModel()
        {
            AvailableRoles = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

       

        public long SelectedRole { get; set; }
        public List <UserRoleMapping> UserRoles{ get; set; }
       
        public IList<SelectListItem> AvailableRoles { get; set; }

        #endregion
    }
}
