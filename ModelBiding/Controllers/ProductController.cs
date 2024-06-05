using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBiding.Models;
using ModelBiding.Repositories;

namespace ModelBiding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IProductRepository productRepository1;
        public ProductController(IProductRepository iproductRepository, IProductRepository iproductRepository1)
        {
            productRepository = iproductRepository;
            productRepository1 = iproductRepository1;
        }

        //[HttpPost("")]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            productRepository.AddProduct(product);
            var products = productRepository1.GetAllProducts();

            return Ok(products);
        }

        //[HttpGet("")]
        public IActionResult GetName()
        {
            var name = productRepository.GetName();

            return Ok(name);
        }

        [HttpGet("")]
        public IActionResult GetName([FromServices] IProductRepository productRepository)
        {
            var name = productRepository.GetName();

            return Ok(name);
        }

    }
}
