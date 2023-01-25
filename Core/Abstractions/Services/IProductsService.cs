using Core.Domain;

namespace Core.Abstractions.Services
{
    public interface IProductsService
    {
        void InsertProduct(Proizvod product);

        List<Proizvod> GetAllProducts();
    }

}