using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
       
    }
}
