using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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