using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShopping.Domain.Model.Goods;

namespace OnlineShopping.Persistence.EF.Repository.Goods
{
    public interface IProductRepository : IRepository
    {
        Task AddAsync(Product product);
        Task<Product> GetByIdAsync(long id);
        Task<List<Product>> GetAllByAsync();
        void Delete(Product product);
    }
}