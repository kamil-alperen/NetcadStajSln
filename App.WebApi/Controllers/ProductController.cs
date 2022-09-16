using App.Business.Services;
using App.Data.Context;
using App.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.WebApi.Controllers
{

    public class ProductController : BaseController
    {
        private readonly ProductService _service;
        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _service.GetProductList());
        }

        [HttpPost]
        public async Task<ActionResult> Save([FromBody] Product request)
        {
            return Ok(await _service.SaveProduct(request));
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] Product request)
        {
            var data = await _service.AddProduct(request);

            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var list = await _service.DeleteProduct(id);

            if (list == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(true);
            }
        }


    }
}
