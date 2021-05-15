using FluentAssertions;
using OnlineShopping.Domain.Model.Goods;
using Xunit;

namespace OnlineShopping.Domain.Tests.Unit
{
    public class GoodsTests
    {
        [Fact]
        public void product_constructed_properly()
        {
            var product = new Product(1, "Samsung", "S7532", 2, 1);

            product.Id.Should().Be(1);
            product.Title.Should().Be("Samsung");
            product.Code.Should().Be("S7532");
            product.MinimumInventory.Should().Be(2);
            product.CategoryId.Should().Be(1);
        }

        [Fact]
        public void category_constructor_properly()
        {
            var category = new Category(1, "Mobile");

            category.Id.Should().Be(1);
            category.Title.Should().Be("Mobile");
        }
    }
}
