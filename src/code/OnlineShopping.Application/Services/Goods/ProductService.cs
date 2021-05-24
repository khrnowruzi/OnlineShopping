using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using OnlineShopping.Application.Models.Goods;
using OnlineShopping.Domain.Model.Goods;
using OnlineShopping.Persistence.EF.Repository.Goods;
using OnlineShopping.Persistence.EF.UnitOfWork;

namespace OnlineShopping.Application.Services.Goods
{
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

        public async Task<long> RegisterProduct(ProductRegisterDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            await _repository.AddAsync(product);
            _uow.Complete();
            return product.Id;
        }
        public async Task<List<ProductRegisterDto>> GetAllProducts()
        {
            return _mapper.Map<List<ProductRegisterDto>>(await _repository.GetAllByAsync());
        }
        public async Task<ProductRegisterDto> GetProductById(long id)
        {
            var product = await _repository.GetByIdAsync(id);
            var dto = _mapper.Map<ProductRegisterDto>(product);
            return dto;
        }

        public async Task DeleteById(long id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product != null)
            {
                _repository.Delete(product);
                _uow.Complete();
            }
        }
    }
}
