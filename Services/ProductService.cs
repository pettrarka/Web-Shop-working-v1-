using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Core.Domain;

namespace Services
{
    public class ProductService : IProductsService
    {
        private readonly IProductsRepository _repository;

        public ProductService(IProductsRepository productRepository)
        {
            _repository = productRepository;
        }
        public List<Proizvod> GetAllProducts()
        {
           return _repository.GetAllProducts();
        }
        public void InsertProduct(Proizvod product)
        {
            if(product == null)
                throw new ArgumentNullException(nameof(product));

            _repository.Insert(product);
        }
    }
}