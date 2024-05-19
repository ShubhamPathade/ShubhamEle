using Microsoft.AspNetCore.Mvc;
using Project.Core.Domain.Electricians;
using Project.Core.Domain.SpModels.Electrician;
using Project.Services.Cities;
using Project.Services.Electricians;
using Project.Services.States;
using Project.Web.Models.DataTable;
using Project.Web.Models.Electricians;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Web.Infrastructure.Factory.Electricians
{
    public class ElectricianModelFactory : IElectricianModelFactory
    {

        #region Propertis
        private readonly ICityService _cityService;
        private readonly IStateService _stateService;
        private readonly IElectricianService _electricianService;
        #endregion

        #region Constructor
        public ElectricianModelFactory(ICityService cityService,
            IStateService stateService,
            IElectricianService electricianService)
        {
            _cityService = cityService;
            _stateService = stateService;
            _electricianService = electricianService;

        }
        #endregion

        #region
        public async Task<IEnumerable<ElectricianSpModel>> PrepareElectrcianDataTableList(ElectricianSearchModel model)
        {
            try
            {              
                return await _electricianService.GetAllElectrician(searchText:model.SearchText,pageIndex:model.PageIndex,pageSize:model.Length); ;
            }
            catch (System.Exception ex)
            {
                ex.Message.ToString();
                throw;
            }
        }
        public async Task<string> DeleteElectrician(long id)
        {
            try
            {           
                Electrician electrician=await _electricianService.GetElectrician(electrcianId:id);
                electrician.ModifiedOn = DateTime.Now;
                electrician.ModifiedBy = 1;
                electrician.IsActive = false;
                await _electricianService.UpdateElectrician(electrician);
                return $"{electrician.FirstName ?? ""} {electrician.LastName??""} deleted successfully !";
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw;
            }
        }

        public async Task<string> RestoreElectrician(long id)
        {
            try
            {
                Electrician electrician = await _electricianService.GetElectrician(electrcianId: id);
                electrician.ModifiedOn = DateTime.Now;
                electrician.ModifiedBy = 1;
                electrician.IsActive = true;
                await _electricianService.UpdateElectrician(electrician);
                return $"{electrician.FirstName ?? ""} {electrician.LastName ?? ""} electrcian restored successfully !";
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw;
            }
        }
        #endregion
    }
}
