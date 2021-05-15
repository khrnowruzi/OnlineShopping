using AutoMapper;
using FluentAssertions;
using NSubstitute;
using OnlineShopping.Application.Goods;
using OnlineShopping.Application.Mapper;
using OnlineShopping.Application.Models;
using OnlineShopping.Domain.Model.Goods;
using OnlineShopping.Persistence.EF.Repository.Goods;
using OnlineShopping.Persistence.EF.UnitOfWork;
using PAP.NSubstitute.FluentAssertionsBridge;
using Xunit;

namespace OnlineShopping.Application.Tests.Unit
{
    public class ProductServiceTests
    {
        [Fact]
        public void saves_a_product_into_database()
        {
            var repository = Substitute.For<IProductRepository>();
            var unitOfWork = Substitute.For<IUnitOfWork>();
            var mapper = new MapperConfiguration(mc =>
                mc.AddProfile(new AutoMapping())).CreateMapper();

            var service = new ProductService(unitOfWork, repository, mapper);

            var dto = new RegisterProductDto()
            {
                Id = 1,
                Code = "S7532",
                Title = "Samsung",
                MinimumInventory = 2,
                CategoryId = 1
            };

            service.Register(dto);

            var expected = new Product(1, "Samsung", "S7532", 2, 1);

            repository.Received(1).AddAsync(Verify.That<Product>(a => a.Should().BeEquivalentTo(expected)));
        }
    }
}