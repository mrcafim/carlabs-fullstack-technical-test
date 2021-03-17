using Microsoft.AspNetCore.Mvc;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Models.Product;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Application.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProductModel product)
        {
            if (product == null)
                return BadRequest("The product information can not be null");

            if (_service.New(product) != null)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Could not add a new product. ");
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] UpdateProductModel product)
        {
            if (product == null)
                return BadRequest("The product information can not be null");

            if (_service.Update(product) != null)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Could not add a new product. ");
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id)
        {
            var product = _service.Get(id);

            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return BadRequest("Could not find a product with the respective ID. ");
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            var productList = _service.Get();

            if (productList != null)
            {
                return Ok(productList);
            }
            else
            {
                return BadRequest("Could not find any product ");
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            if (id == null) return BadRequest(new { Error = "The parameter id can not be null." });

            _service.Delete(id);

            return Ok();

        }
    }
}