using App.WebApi.Controllers;
using App.Business.Services;
using Microsoft.AspNetCore.Mvc;
using App.Data.Entities;

namespace Login.WebAPI.Controllers
{
    public class LoginController : BaseController
    {
        private readonly LoginService _service;

        public LoginController(LoginService service)
        {
            _service = service;
        }


        [HttpGet]

        public async Task<ActionResult> GetBusinessList()
        {
            return Ok(await _service.GetBusinessList());
        }

        [HttpPost]

        public async Task<ActionResult> AddBusiness([FromBody] Business request)
        {
            var data = await _service.AddBusiness(request);

            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }
    }
}
