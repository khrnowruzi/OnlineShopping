using FluentAssertions;
using OnlineShopping.Application.Goods;
using OnlineShopping.Application.Models;
using OnlineShopping.Persistence.EF.Repository.Goods;
using Xunit;

namespace OnlineShopping.Application.Tests.Integration
{
    public class GoodsServiceTests : HelpTest
    {
        [Fact]
        public void saves_a_product_into_database()
        {
            var repository = new ProductRepository(DbContext);

            var service = new ProductService(UnitOfWork, repository, Mapper);

            var newId = service.Register(new RegisterProductDto()
            {
                Code = "S7532",
                Title = "Samsung",
                MinimumInventory = 2,
                CategoryId = 1
            }).Result;

            var expected = new RegisterProductDto()
            {
                Id = newId,
                Code = "S7532",
                Title = "Samsung",
                MinimumInventory = 2,
                CategoryId = 1
            };

            this.DetachAllEntities();
            var newProduct = service.GetById(newId).Result;
            newProduct.Should().BeEquivalentTo(expected);
        }
    }
}
