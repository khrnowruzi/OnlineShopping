using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using NSubstitute;
using OnlineShopping.Application.Mapper;
using OnlineShopping.Application.Models.Goods;
using OnlineShopping.Application.Services.Goods;
using OnlineShopping.Domain.Model.Goods;
using OnlineShopping.Persistence.EF.Repository.Goods;
using OnlineShopping.Persistence.EF.UnitOfWork;
using PAP.NSubstitute.FluentAssertionsBridge;
using Xunit;

namespace OnlineShopping.Application.Tests.Unit
{
    public class ProductServiceUnitTests
    {
        [Fact]
        public async Task Register_a_product_using_service()
        {
            var repository = Substitute.For<IProductRepository>();
            var unitOfWork = Substitute.For<IUnitOfWork>();
            var mapper = new MapperConfiguration(mc => mc.AddProfile(new AutoMapping())).CreateMapper();

            var service = new ProductService(unitOfWork, repository, mapper);

            var dto = new ProductRegisterDto()
            {
                Id = 1,
                Code = "S7532",
                Title = "Samsung",
                MinimumInventory = 2,
                CategoryId = 1
            };

            await service.RegisterProduct(dto);

            var expected = new Product(1, "Samsung", "S7532", 2, 1);

            await repository.Received(1).AddAsync(Verify.That<Product>(a => a.Should().BeEquivalentTo(expected)));
        }
    }
}