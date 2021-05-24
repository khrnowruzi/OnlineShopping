using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShopping.Application.Models.Goods;

namespace OnlineShopping.Application.Services.Goods
{
    public interface IProductService
    {
        Task<long> RegisterProduct(ProductRegisterDto dto);
        Task<List<ProductRegisterDto>> GetAllProducts();
        Task<ProductRegisterDto> GetProductById(long id);
        Task DeleteById(long id);
    }
}