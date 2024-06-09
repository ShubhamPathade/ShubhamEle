﻿using Microsoft.AspNetCore.Mvc.Rendering;
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
            get => _unitOfWork.GetRepository<City>();
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<SelectListItem>> GetCityByStateId(long stateId)
        {
            return await (CityRepository.Table.Where(x => x.StateId == stateId).Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToListAsync());
        }

        public async Task<City> GetCity(long cityId)
        {
            if (cityId == 0)
                throw new ArgumentNullException(nameof(cityId));

            return await CityRepository.GetByIdAsync(cityId);
        }
        #endregion
    }
}