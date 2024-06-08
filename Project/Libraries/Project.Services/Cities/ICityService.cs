using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.Domain.Cities;
using Project.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Cities
{
    public interface ICityService
    {
        Task<City> GetCity(long cityId);
        Task<IEnumerable<SelectListItem>> GetCityByStateId(long stateId);

    }
}
