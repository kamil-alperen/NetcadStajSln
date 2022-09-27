using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    public abstract class BaseController : Controller
    {
       
    }
}
