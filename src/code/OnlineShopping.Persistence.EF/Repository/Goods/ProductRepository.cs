using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Domain.Model.Goods;

namespace OnlineShopping.Persistence.EF.Repository.Goods
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task<Product> GetByIdAsync(long id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<List<Product>> GetAllByAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
        }
    }
}