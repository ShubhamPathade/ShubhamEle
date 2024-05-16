using Project.Core.Domain.Electricians;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Electricians
{
    public interface IElectricianService
    {
        Task InsertElectrician(Electrician electrician);
        Task<IEnumerable<Electrician>> GetAllElectrician();
        Task<Electrician> GetElectrician(long electrcianId);
    }
}
