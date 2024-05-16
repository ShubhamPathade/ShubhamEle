using Project.Core.Data;
using Project.Core.Domain.Electricians;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Electricians
{
    public class ElectricianService : IElectricianService
    {
        #region Properties
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public ElectricianService(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }
        #endregion

        #region Repository
        protected IRepository<Electrician> ElectricianRepository
        {
            get=>_unitOfWork.GetRepository<Electrician>();
        }
        #endregion

        public async Task<IEnumerable<Electrician>> GetAllElectrician()
        {
            return await ElectricianRepository.GetAllAsync();   
        }

        public Task<Electrician> GetElectrician(long electrcianId)
        {
            throw new NotImplementedException();
        }

        public async Task InsertElectrician(Electrician electrician)
        {

            if (electrician== null)
                throw new ArgumentNullException(nameof(electrician));

            ElectricianRepository.Insert(electrician);

            await _unitOfWork.SaveAsync();

        }
    }
}
