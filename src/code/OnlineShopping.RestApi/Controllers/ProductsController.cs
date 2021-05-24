using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using OnlineShopping.Application.Models.Goods;
using OnlineShopping.Application.Services.Goods;

namespace OnlineShopping.RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Api is up...");
        }

        [HttpPost]
        public async Task<long> RegisterProduct(ProductRegisterDto dto)
        {
            return await _service.RegisterProduct(dto);
        }

        [HttpGet("{id:long}")]
        public async Task<ProductRegisterDto> GetProductById(long id)
        {
            return await _service.GetProductById(id);
        }

        [HttpGet("AllProduct")]
        public async Task<List<ProductRegisterDto>> GetAllProducts()
        {
            return await _service.GetAllProducts();
        }

        [HttpDelete("{id:long}")]
        public async Task DeleteProductById(long id)
        {
            await _service.DeleteById(id);
        }
    }
}
