using App.Business.Models.License;
using App.Business.Services;
using Microsoft.AspNetCore.Mvc;
using App.Data.Entities;

namespace App.WebApi.Controllers
{
    public class LicenseController : BaseController
    {
        private readonly LicenseService _service;
        public LicenseController(LicenseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetLicense(long businessID)
        {
            var license = await _service.GetLicense(businessID);
            return Ok(license);
        }

        [HttpPost]
        public async Task<ActionResult> AddLicense([FromBody] License license)
        {
            return Ok(await _service.AddLicense(license));
        }
    }
}
