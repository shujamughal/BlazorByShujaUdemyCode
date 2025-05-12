using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductsController(ProductService service) => _service = service;

        [HttpGet]
        public ActionResult<List<Product>> Get() => _service.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
            => _service.GetById(id) is { } product ? Ok(product) : NotFound();

        [HttpPost]
        public IActionResult Post(Product product)
        {
            _service.Add(product);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            _service.Update(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }

}
