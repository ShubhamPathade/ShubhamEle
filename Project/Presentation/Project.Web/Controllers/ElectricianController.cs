using Microsoft.AspNetCore.Mvc;

namespace Project.Web.Controllers
{
    public class ElectricianController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
