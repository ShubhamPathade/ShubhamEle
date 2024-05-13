using Microsoft.AspNetCore.Mvc;

namespace Project.Web.Controllers
{
	public class TraderController : BaseController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
