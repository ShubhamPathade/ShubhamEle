using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    //[Authorize]
    public class BaseController : ControllerBase
    {

    }
}
