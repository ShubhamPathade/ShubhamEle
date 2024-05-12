using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Services.Users
{
    public interface ILoginRepository
    {
        bool Login(string Email, string Password);
    }
}
