using Microsoft.EntityFrameworkCore;
using Project.Core.Data;
using Project.Core.Domain.Cities;
using Project.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Cities
{
    public class CityService : ICityService
    {
        #region Properties
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public CityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Fields
        protected IRepository<City> CityRepository
        {
            get=> _unitOfWork.GetRepository<City>();
        }
        #endregion
        public async Task<List<DropDownModel>> GetCityByStateId(long stateId)
        {
            return await (CityRepository.Table.Select(x => new DropDownModel
            {
                Id=x.Id.ToString(),
                Value=x.Name
            }).ToListAsync());
        }
    }
}
