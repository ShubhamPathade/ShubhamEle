using Microsoft.AspNetCore.Mvc;
using Project.Core.Domain.States;
using Project.Services.States;
using Project.Web.Infrastructure.Mapper.Extensions;
using Project.Web.Models.States;
using System;
using System.Threading.Tasks;

namespace Project.Web.Controllers
{
	public class StateController : Controller
	{
		#region Properties
		private readonly IStateService _stateService;
		#endregion

		#region Constructor
		public StateController(IStateService stateService)
		{
			_stateService = stateService;
		}
		#endregion
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddState(StateModel model)
		{
			if (model == null)
			{
				return Json(new { message = "Fail" });
			}

			State state = model.ToEntity<State>();
			state.CreatedOn = DateTime.Now;
			state.IsActive = true;

			await _stateService.InsertState(state);
			return Json(new { message = "Ok" });
		}

	}
}
