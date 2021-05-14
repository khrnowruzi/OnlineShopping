using AutoMapper;
using OnlineShopping.Application.Models;
using OnlineShopping.Domain.Model.Goods;
using OnlineShopping.Persistence.EF.Repository.Goods;
using OnlineShopping.Persistence.EF.UnitOfWork;

namespace OnlineShopping.Application.Goods
{
    public interface IProductService
    {

    }
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork uow, IProductRepository repository, IMapper mapper)
        {
            _uow = uow;
            _repository = repository;
            _mapper = mapper;
        }

        public void Register(RegisterProductDto productDto)
        {
            _repository.AddAsync(_mapper.Map<Product>(productDto));
            _uow.Complete();
        }
    }
}
