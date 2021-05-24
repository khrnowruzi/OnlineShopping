using FluentAssertions;
using OnlineShopping.Domain.Model.Goods;
using Xunit;

namespace OnlineShopping.Domain.Tests.Unit.Goods
{
    public class CategoryUnitTests
    {
        [Fact]
        public void Category_constructor_properly()
        {
            var category = new Category(1, "Mobile");

            category.Id.Should().Be(1);
            category.Title.Should().Be("Mobile");
        }
    }
}