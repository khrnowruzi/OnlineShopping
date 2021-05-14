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
            var product = new Product("Samsung", "S7532", 2, 1);

            product.Title.Should().Be("Samsung");
            product.Code.Should().Be("S7532");
            product.MinimumInventory.Should().Be(2);
            product.CategoryId.Should().Be(1);
        }

        [Fact]
        public void category_constructor_properly()
        {
            var category = new Category("Mobile");

            category.Title.Should().Be("Mobile");
        }
    }
}
