using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.Domain.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Services.Roles
{
    public interface IRoleService
    {
        #region Methods

        Task<IList<SelectListItem>> GetRoleSelectList();
        Task<IEnumerable<Role>> GetRolesAsync();
        Task<Role> GetRoleAsync(long id);
        Task InsertRoleAsync(Role role);
        Task UpdateRoleAsync(Role role);
        Task DeleteRoleAsync(Role role);

        #endregion
    }
}
