using TheCoffee.src.Domain.Model.Products;
using TheCoffee.src.Domain.Model.Store;
using TheCoffee.src.User_Interface.Contracts.Requests;

namespace TheCoffee.src.Application.Service
{
    public interface IProductService
    {
        public ICollection<Product> GetProducts();
        public Product GetProductById(int id);
        public ICollection<Product> GetProductsByFilter(GetProductQuery filter);
        public ICollection<Characteristic> GetProductsCharacteristics();
        public ICollection<Product> GetProductsAndCharacteristics(GetProductQuery filter);
        public Product AddProduct(Product product);
        public Product UpdateProduct(Product product);
    }
}
