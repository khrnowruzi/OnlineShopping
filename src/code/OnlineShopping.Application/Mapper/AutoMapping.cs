using AutoMapper;
using OnlineShopping.Application.Models.Goods;
using OnlineShopping.Domain.Model.Goods;

namespace OnlineShopping.Application.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ProductRegisterDto, Product>()
                .ForMember(product => product.Id, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}