using Microsoft.EntityFrameworkCore;
using Project.Core.Data;
using Project.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Users
{
    public class UserService : IUserService
    {
        #region Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Properties

        protected IRepository<User> UserRepository
        {
            get => _unitOfWork.GetRepository<User>();
        }
        protected IRepository<UserRoleMapping> RoleMappingRepository
        {
            get => _unitOfWork.GetRepository<UserRoleMapping>();
        }

        #endregion

        #region Constructor

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        public Task DeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var list = await UserRepository.Table
                  .Include(user => user.UserRoles)
                 .ThenInclude(user => user.Role).ToListAsync();
            return list;
        }

        public async Task<User> GetUserAsync(long id)
        {
            if (id == 0)
                return null;
            var user = await UserRepository.GetByIdAsync(id);
            return user;
        }

        public async Task<UserRoleMapping> GetUserAsyncByID(long id)
        {
            var query =  RoleMappingRepository.Table.Where(x => x.UserId == id).FirstOrDefault();

            return query;
        }

        public async Task<long> InsertUsesAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            UserRepository.Insert(user);
           await _unitOfWork.SaveAsync();
            return user.Id;
        }

        public async Task<long> InsertUserRoleMappingAsync(UserRoleMapping userRole)
        {
            if (userRole == null)
                throw new ArgumentNullException(nameof(userRole));

            RoleMappingRepository.Insert(userRole);
            await _unitOfWork.SaveAsync();
            return userRole.Id;
        }
        public async Task UpdateUserAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            UserRepository.Update(user);
            await _unitOfWork.SaveAsync();
        }
        public async Task UpdateUserRoleMappingAsync(UserRoleMapping user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            RoleMappingRepository.Update(user);
            await _unitOfWork.SaveAsync();
        }

        public async Task<User> ValidateUsernameAndPassword(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException(nameof(email));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password));

            var query = UserRepository.Table;
            query = query.Where(user => user.Email.Equals(email) && user.Password.Equals(password));
            var user = await query
                  .Include(user => user.UserRoles)
                 .ThenInclude(user => user.Role)
                 .FirstOrDefaultAsync();

            return user;
        }

        public User GetUserInfoByMobileNumber(string mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
                throw new ArgumentNullException(nameof(mobileNumber));

            var query = UserRepository.Table;
            var user = query.FirstOrDefault(user => user.MobileNo.Equals(mobileNumber));
            return user;
        }

        public async Task<User> GetUserInfoByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException(nameof(email));

            var query = UserRepository.Table;
            var user = await query.FirstOrDefaultAsync(user => user.Email.Equals(email));
            return user;
        }



        #endregion
    }
}
