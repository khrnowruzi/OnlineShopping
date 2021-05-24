using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Domain.Model.Goods;

namespace OnlineShopping.Persistence.EF
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; protected set; }
        public DbSet<Category> Categories { get; protected set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
