using System.Threading.Tasks;
using FluentAssertions;
using OnlineShopping.Application.Models.Goods;
using OnlineShopping.Application.Services.Goods;
using OnlineShopping.Persistence.EF.Repository.Goods;
using Xunit;

namespace OnlineShopping.Application.Tests.Integration
{
    public class ProductServiceIntegrationTests : IntegrationHookTest
    {
        [Fact]
        public async Task Saves_a_product_into_database()
        {
            var repository = new ProductRepository(DbContext);
            var service = new ProductService(UnitOfWork, repository, Mapper);
            var newProductId = await service.RegisterProduct(new ProductRegisterDto()
            {
                Code = "S7532",
                Title = "Samsung",
                MinimumInventory = 2,
                CategoryId = 1
            });

            var expected = new ProductRegisterDto()
            {
                Id = newProductId,
                Code = "S7532",
                Title = "Samsung",
                MinimumInventory = 2,
                CategoryId = 1
            };

            this.DetachAllEntities();
            var newProduct = service.GetProductById(newProductId).Result;
            newProduct.Should().BeEquivalentTo(expected);
        }
    }
}
