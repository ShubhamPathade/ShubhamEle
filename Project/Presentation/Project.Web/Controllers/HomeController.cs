using Microsoft.AspNetCore.Mvc;

namespace Project.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
