using Project.Core.Domain.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Services.Users
{
    public interface IUserService
    {
        #region Methods
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserAsync(long id);
        Task<UserRoleMapping> GetUserAsyncByID(long id);
        Task<long> InsertUsesAsync(User user);
        Task<long> InsertUserRoleMappingAsync(UserRoleMapping userRole);
        Task UpdateUserAsync(User user);
        Task UpdateUserRoleMappingAsync(UserRoleMapping user);
        Task DeleteUserAsync(User user);
        Task<User> ValidateUsernameAndPassword(string email, string password);
        User GetUserInfoByMobileNumber(string mobileNumber);
        Task<User> GetUserInfoByEmail(string email);

        #endregion
    }
}
