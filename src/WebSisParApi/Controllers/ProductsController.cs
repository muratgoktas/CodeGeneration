using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSisParApi.Repositories.ProductRepository;

namespace WebSisParApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ProducList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("ProducListWithCategory")]
        public async Task<IActionResult> ProducListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
    }
}
