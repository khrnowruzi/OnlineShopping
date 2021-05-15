using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using OnlineShopping.Application.Goods;
using OnlineShopping.Application.Models;

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
        public async Task<long> Register(RegisterProductDto dto)
        {
            var test = await _service.Register(dto);
            return test;
        }

        [HttpGet("{id:long}")]
        public async Task<RegisterProductDto> GetById(long id)
        {
            return await _service.GetById(id);
        }

        [HttpGet("AllProduct")]
        public async Task<List<RegisterProductDto>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpDelete("{id:long}")]
        public async Task DeleteById(long id)
        {
            await _service.DeleteById(id);
        }
    }
}
