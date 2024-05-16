using Microsoft.AspNetCore.Mvc;
using Project.Core.Domain.Common;
using Project.Services.Cities;
using Project.Web.Framework.Models;
using Project.Web.Models.BaseResponse;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Web.Controllers
{
    public class CityController : BaseController
    {

        #region Properties
        private readonly ICityService _cityService;
        #endregion

        #region Constructor
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetCityByState(long stateId)
        {
            var response = new BaseResponse<List<DropDownModel>>();
            response.Messaage = "Ok";
            response.Status = Status.Success;
            try
            {

                response.Data = await _cityService.GetCityByStateId(stateId:stateId);
                return Json(response);

            }
            catch (System.Exception ex)
            {

                response.Messaage = ex.Message;
                response.Status = Status.Fail; 
                return Json(response);

            }
        }
    }
}
