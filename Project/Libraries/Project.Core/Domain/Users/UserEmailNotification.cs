using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Core.Domain.Users
{
    public class UserEmailNotification
    {
      
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CallBackUrl { get; set; }
        public string UserEmail { get; set; }
    }
}
