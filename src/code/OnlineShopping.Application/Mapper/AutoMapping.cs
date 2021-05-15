using AutoMapper;
using OnlineShopping.Application.Models;
using OnlineShopping.Domain.Model.Goods;

namespace OnlineShopping.Application.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<RegisterProductDto, Product>()
                .ForMember(product => product.Id, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}