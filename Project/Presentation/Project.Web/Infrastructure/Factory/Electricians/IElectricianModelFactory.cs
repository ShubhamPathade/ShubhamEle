using Project.Core.Domain.Electricians;
using Project.Core.Domain.SpModels.Electrician;
using Project.Web.Models.DataTable;
using Project.Web.Models.Electricians;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Web.Infrastructure.Factory.Electricians
{
    public interface IElectricianModelFactory
    {
        Task<string> DeleteElectrician(long id);
        Task<string> RestoreElectrician(long id);
        Task<IEnumerable<ElectricianSpModel>> PrepareElectrcianDataTableList(ElectricianSearchModel model);
    }
}
