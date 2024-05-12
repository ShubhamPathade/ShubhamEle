using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Core.Data;
using Project.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Services.Roles
{
    public class RoleService : IRoleService
    {
        #region Fields

        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructor

        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region Properties

        protected IRepository<Role> RoleRepository
        {
            get => _unitOfWork.GetRepository<Role>();
        }


        #endregion

        #region Methods
        public async Task DeleteRoleAsync(Role role)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            RoleRepository.Delete(role);
            _ = await _unitOfWork.SaveAsync();
        }

        public async Task<Role> GetRoleAsync(long id)
        {
            if (id == 0)
                return null;

            var role = await RoleRepository.GetByIdAsync(id);
            return role;
        }

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            var list = await RoleRepository.Table.ToListAsync();
            return list;
        }

        public async Task<IList<SelectListItem>> GetRoleSelectList()
        {
            var query = RoleRepository.Table;

            var list = query.Select(role => new SelectListItem() { Text = role.RoleName, Value = role.Id.ToString() });
            return await list.ToListAsync();
        }

        public async Task InsertRoleAsync(Role role)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            RoleRepository.Insert(role);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateRoleAsync(Role role)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            RoleRepository.Update(role);
            await _unitOfWork.SaveAsync();
        }

        #endregion
    }
}
