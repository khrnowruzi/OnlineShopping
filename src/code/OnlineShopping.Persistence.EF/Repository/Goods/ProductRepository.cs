using System.Threading.Tasks;
using OnlineShopping.Domain.Model.Goods;

namespace OnlineShopping.Persistence.EF.Repository.Goods
{
    public interface IProductRepository : IRepository
    {
        Task AddAsync(Product product);
    }
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }
    }
}