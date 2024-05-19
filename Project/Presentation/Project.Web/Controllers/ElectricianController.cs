using Microsoft.AspNetCore.Mvc;
using Project.Core.Domain.Electricians;
using Project.Services.Cities;
using Project.Services.Electricians;
using Project.Services.States;
using Project.Web.Framework.Models;
using Project.Web.Infrastructure.Factory.Electricians;
using Project.Web.Infrastructure.Mapper.Extensions;
using Project.Web.Models.BaseResponse;
using Project.Web.Models.Common;
using Project.Web.Models.DataTable;
using Project.Web.Models.Electricians;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Web.Controllers
{
    public class ElectricianController : BaseController
    {
        #region Propertis
        private readonly ICityService _cityService;
        private readonly IStateService _stateService;
        private readonly IElectricianService _electricianService;
        private readonly IElectricianModelFactory _electricianModelFactory;
        #endregion

        #region Constructor
        public ElectricianController(ICityService cityService,
            IStateService stateService,
            IElectricianService electricianService,
            IElectricianModelFactory electricianModelFactory)
        {
            _cityService = cityService; 
            _stateService = stateService;
            _electricianService = electricianService;
            _electricianModelFactory = electricianModelFactory;

        }
        #endregion

        #region Methods
        public async Task<IActionResult> Index()
        {
            ElectricianModel model = new ElectricianModel();
            model.StateDropDown = await _stateService.PrepareStateDropDown();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterElectrician(ElectricianModel electricianModel)
        {
            var baseResponse = new BaseResponse<string>();
            try
            {
                Electrician electrician = electricianModel.ToEntity<Electrician>();
                electrician.CreatedOn = DateTime.Now;
                await _electricianService.InsertElectrician(electrician);
                baseResponse.Message = $"{electrician.FirstName} {electrician.LastName} successfully registered.";
                baseResponse.Status = Status.Success;
                return Json(baseResponse);
            }
            catch (Exception ex)
            {
                baseResponse.Message = ex.Message;
                baseResponse.Status = Status.Fail;
                return Json(baseResponse);
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetElectricians(ElectricianSearchModel model)
        {
            var electricianList = await _electricianModelFactory.PrepareElectrcianDataTableList(model);
            var count = electricianList.Count() > 0 ? electricianList.FirstOrDefault().TotalCount : 0;
            var list = new
            {
                Data = electricianList,
                Draw = model.Draw,
                RecordsFiltered = count,
                RecordsTotal = count
            };
            return Json(list);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteElectrician(long id)
        {
            var response= new BaseResponse<string>();
            response.Data = "";
            response.Message = await _electricianModelFactory.DeleteElectrician(id);
            response.Status = Status.Success;
            return Json(response);
        }

        [HttpGet]
        public async Task<IActionResult> RestoreElectrician(long id)
        {
            var response = new BaseResponse<string>();
            response.Data = "";
            response.Message = await _electricianModelFactory.RestoreElectrician(id);
            response.Status = Status.Success;
            return Json(response);
        }
        #endregion
    }
}
