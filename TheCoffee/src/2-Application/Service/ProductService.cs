using TheCoffee.src.Domain.Model.Products;
using TheCoffee.src.Infrastructure.Repositories;
using TheCoffee.src.User_Interface.Contracts.Requests;


namespace TheCoffee.src.Application.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository) => _repository = repository;

        public  ICollection<Product> GetProducts()
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetProducts();
        }
        public ICollection<Characteristic> GetProductsCharacteristics()
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetProductsCharacteristics();
        }

        public ICollection<Product> GetProductsAndCharacteristics(GetProductQuery filter)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetProductsAndCharacteristics(filter);
        }
        public Product GetProductById(int i)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetProduct(i);
        }
        public ICollection<Product> GetProductsByFilter(GetProductQuery f)
        {                       
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetFilteredProducts(f);
        }

        public Product AddProduct(Product property)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.AddProduct(property);
        }
        public Product UpdateProduct(Product property)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.UpdateProduct(property);
        }
       
    }
}
