using Project.Core.Constants;
using Project.Core.Data;
using Project.Core.Domain.Electricians;
using Project.Core.Domain.SpModels.Electrician;
using Project.Data;
using Project.Services.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Services.Electricians
{
    public class ElectricianService : BaseModelService, IElectricianService
    {
        #region Properties
        private readonly IUnitOfWork _unitOfWork;
        private readonly IModelService<ElectricianSpModel> _electricianModelService;
        #endregion

        #region Constructor
        public ElectricianService(IUnitOfWork unitOfWork,
            IModelService<ElectricianSpModel> modelService)
        {
            _unitOfWork = unitOfWork;
            _electricianModelService = modelService;
        }
        #endregion

        #region Repository
        protected IRepository<Electrician> ElectricianRepository
        {
            get => _unitOfWork.GetRepository<Electrician>();
        }
        #endregion

        public async Task<IEnumerable<ElectricianSpModel>> GetAllElectrician(string searchText = "", bool? status = null, string orderBy = OrderBy.Descending, int pageIndex = 0, int pageSize = 10)
        {
            try
            {
                AddSqlParameter("SearchText", searchText??"");
                AddSqlParameter("Status", (status != null) ? ((status == true) ? 1 : 0) : 2);
                AddSqlParameter("PageIndex", pageIndex);
                AddSqlParameter("PageLength", pageSize);
                AddSqlParameter("OrderBy", orderBy);
                var electricianList = await _electricianModelService.ModelFromSqlAsync(StoredProcedureMapping.spGetAllElectrcians, Parameters);
                ClearAllParameters();
                return electricianList;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw;
            }
        }

        public async Task<Electrician> GetElectrician(long electrcianId)
        {
            if (electrcianId <= 0)
                throw new ArgumentNullException(nameof(electrcianId));

            return await ElectricianRepository.GetByIdAsync(electrcianId);  
        }

        public async Task InsertElectrician(Electrician electrician)
        {

            if (electrician == null)
                throw new ArgumentNullException(nameof(electrician));

            ElectricianRepository.Insert(electrician);

            await _unitOfWork.SaveAsync();

        }

        public async Task UpdateElectrician(Electrician electrician)
        {

            if(electrician==null)
                throw new ArgumentNullException(nameof(electrician));

            ElectricianRepository.Update(electrician);

            await _unitOfWork.SaveAsync();

        }
    }
}
