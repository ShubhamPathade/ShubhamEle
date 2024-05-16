using Project.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Cities
{
    public interface ICityService
    {
        Task<List<DropDownModel>> GetCityByStateId(long stateId);
        
    }
}
