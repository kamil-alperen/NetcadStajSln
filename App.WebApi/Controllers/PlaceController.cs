using App.Business.Services;
using App.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers
{
    public class PlaceController : BaseController
    {
        private readonly PlaceService _service;
        public PlaceController(PlaceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _service.GetPlaceList());
        }

        [HttpGet]
        public async Task<ActionResult> Get(string name)
        {
            return Ok(await _service.CreatePolygon(name));
            
        }

    }
}
