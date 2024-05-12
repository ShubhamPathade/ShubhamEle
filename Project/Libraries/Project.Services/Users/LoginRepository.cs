using Project.Core.Domain.Users;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Services.Users
{
    public class LoginRepository :ILoginRepository
    {
        private readonly IDbContext _dbContext;

        public LoginRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  bool Login(string Email,string Password)
        {
            User user = _dbContext.Set<User>().Where(u => u.Email == Email && u.Password == Password).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;

        }
    }
}
