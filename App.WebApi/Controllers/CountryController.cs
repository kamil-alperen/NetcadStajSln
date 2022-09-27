using App.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers
{
    public class CountryController : BaseController
    {
        private readonly CountryService _service;
        public CountryController(CountryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll(int limit)
        {
            if (limit >= 0)
            {
                return Ok(await _service.GetCountryList(limit));
            }
            else
            {
                return BadRequest();
            }
            
        }

        [HttpGet]
        public async Task<ActionResult> Get(string name)
        {
            return Ok(await _service.GetCountry(name));
        }

        [HttpGet]
        public async Task<ActionResult> GetSize()
        {
            return Ok(await _service.GetSize());
        }

    }
}
