using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Core.Domain.Cities;
using Project.Core.Domain.Common;
using Project.Core.Domain.Electricians;
using Project.Core.Domain.SpModels.Common;
using Project.Core.Domain.SpModels.Electrician;
using Project.Services.Cities;
using Project.Services.Electricians;
using Project.Services.States;
using Project.Web.Infrastructure.Mapper.Extensions;
using Project.Web.Models.Common;
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
        public async Task<BaseDatatableListModel<ElectricianSpModel>> PrepareElectrcianDataTableList(ElectricianSearchModel model)
        {
            try
            {
                TotalCountModel totalCount = await _electricianService.GetAllElectricianCount(searchText:model.SearchText,status:model.Status);
                var response=new BaseDatatableListModel<ElectricianSpModel>();
                response.Data= await _electricianService.GetAllElectrician(searchText:model.SearchText,status:model.Status,pageIndex:model.PageIndex,pageSize:model.Length); ;
                response.RecordsFiltered = totalCount.TotalCount;
                response.RecordsTotal = totalCount.TotalCount;
                response.Draw = model.Draw;
                return response;
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

        public async Task<ElectricianModel> GetElectricianAsync(long id)
        {
            var electrcianData= (await _electricianService.GetElectrician(electrcianId:id)).ToModel<ElectricianModel>();
            electrcianData.StateDropDown = await _stateService.PrepareStateDropDown();
            var city =electrcianData.CityId.HasValue? await _cityService.GetCity(electrcianData.CityId.Value): new City();
            var cityList= new List<SelectListItem>();
            cityList.Add(new SelectListItem() {Text=city.Name, Value=city.Id.ToString() });          
            electrcianData.CityDropDown = cityList;
            return electrcianData;
        }
        #endregion
    }
}
