using Microsoft.AspNetCore.Mvc;
using Project.Core.Domain.Electricians;
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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Web.Controllers
{
    public class ElectricianController : BaseController
    {
        #region Propertis
        private readonly IStateService _stateService;
        private readonly IElectricianService _electricianService;
        private readonly IElectricianModelFactory _electricianModelFactory;
        #endregion

        #region Constructor
        public ElectricianController(
            IStateService stateService,
            IElectricianService electricianService,
            IElectricianModelFactory electricianModelFactory)
        {
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
            var baseResponse = new BaseResponse<List<ErrorModel>>();
            try
            {
                if (ModelState.IsValid)
                {
                    Electrician electrician = electricianModel.ToEntity<Electrician>();
                    if (electricianModel.Id <= 0)
                    {
                        await _electricianService.InsertElectrician(electrician);
                        baseResponse.Message = $"{electrician.FirstName} {electrician.LastName} successfully registered.";
                        baseResponse.Status = Status.Success;
                    }
                    else if (electricianModel.Id > 0)
                    {
                        electrician.ModifiedOn = DateTime.Now;
                        await _electricianService.UpdateElectrician(electrician);
                        baseResponse.Message = $"{electrician.FirstName} {electrician.LastName} successfully updated.";
                        baseResponse.Status = Status.Success;
                    }
                    return Json(baseResponse);
                }
                else
                {
                    var errors = ModelState
                               .Where(ms => ms.Value.Errors.Any())
                               .Select(ms => new ErrorModel
                               {
                                   Key = ms.Key,
                                   Value = ms.Value.Errors.FirstOrDefault().ErrorMessage
                               })
                               .ToList();

                    baseResponse.Message = $"Provided data is no valid";
                    baseResponse.Status = Status.Fail;
                    baseResponse.Data = errors;
                    baseResponse.ErrorOccured = true;
                    return Json(baseResponse);
                }
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
            try
            {

                var electricianList = await _electricianModelFactory.PrepareElectrcianDataTableList(model);
                return Json(electricianList);

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> CreateElectrician()
        {
            ElectricianModel model = new ElectricianModel();
            model.StateDropDown = await _stateService.PrepareStateDropDown();
            return PartialView("_CreateOrUpdate", model);
        }

        [HttpGet]
        public async Task<IActionResult> EditElectrician(long id)
        {
            var electrcianData = await _electricianModelFactory.GetElectricianAsync(id);
            return PartialView("_CreateOrUpdate", electrcianData);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteElectrician(long id)
        {
            var response = new BaseResponse<string>();
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
