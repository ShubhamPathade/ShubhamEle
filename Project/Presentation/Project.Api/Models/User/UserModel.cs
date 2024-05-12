using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Api.Models.User
{
    public class UserModel
    {


        #region Properties

        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string OTP { get; set; }



        #endregion
    }
}
