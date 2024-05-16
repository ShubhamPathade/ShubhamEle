using Microsoft.AspNetCore.Mvc;
using Project.Core.Domain.Electricians;
using Project.Services.Electricians;
using Project.Services.States;
using Project.Web.Framework.Models;
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
        private readonly IStateService _stateService;
        private readonly IElectricianService _electricianService;
        #endregion

        #region Constructor
        public ElectricianController(IStateService stateService,
            IElectricianService electricianService)
        {
            _stateService = stateService;
            _electricianService = electricianService;

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
            var baseResponse=new BaseResponse<string>();
            try
            {
                Electrician electrician = electricianModel.ToEntity<Electrician>();
                electrician.CreatedOn = DateTime.Now;
                await _electricianService.InsertElectrician(electrician);
                baseResponse.Messaage = $"{electrician.FirstName} {electrician.LastName} successfully registered.";
                baseResponse.Status = Status.Success;
                return Json(baseResponse);
            }
            catch (Exception ex)
            {
                baseResponse.Messaage = ex.Message;
                baseResponse.Status = Status.Fail;
                return Json(baseResponse);
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetElectricians(ElectricianSearchModel model)
        {
            var eletricianList = await _electricianService.GetAllElectrician();

            var list=eletricianList.Select(x=>x.ToModel<ElectricianModel>());

            ElectricianDataTableListModel electricianDataTableListModel = new ElectricianDataTableListModel();
            electricianDataTableListModel.Data=list;
            electricianDataTableListModel.Draw = model.Draw;
            electricianDataTableListModel.RecordsFiltered = 40;
            electricianDataTableListModel.RecordsTotal = 40;
            return Json(electricianDataTableListModel);
        }
        #endregion
    }
}
