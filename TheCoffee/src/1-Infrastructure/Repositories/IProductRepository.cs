using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.Domain.Model.Products;
using TheCoffee.src.User_Interface.Contracts.Requests;

namespace TheCoffee.src.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        ICollection<Product> GetProducts();
        ICollection<Product> GetProductsAndCharacteristics(GetProductQuery filter);
        ICollection<Characteristic> GetProductsCharacteristics();
        ICollection<Product> GetFilteredProducts(GetProductQuery filter);
        Product GetProduct(int id);
        Product AddProduct([FromBody] Product property);
        Product UpdateProduct([FromBody] Product Property);
    }
}
