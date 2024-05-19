using Project.Core.Constants;
using Project.Core.Domain.Electricians;
using Project.Core.Domain.SpModels.Electrician;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Electricians
{
    public interface IElectricianService
    {
        Task InsertElectrician(Electrician electrician);
        Task UpdateElectrician(Electrician electrician);
        Task<Electrician> GetElectrician(long electrcianId);
        Task<IEnumerable<ElectricianSpModel>> GetAllElectrician(string searchText="",bool? status=null, string orderBy= OrderBy.Descending, int pageIndex=0, int pageSize = 10);
    }
}
