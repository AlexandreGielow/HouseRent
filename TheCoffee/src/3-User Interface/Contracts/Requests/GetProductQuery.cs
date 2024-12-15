using TheCoffee.src.Domain.Model.Order;
using TheCoffee.src.Domain.Model.Products;
using TheCoffee.src.Domain.Model.Store;

namespace TheCoffee.src.User_Interface.Contracts.Requests
{
    public class GetProductQuery
    {
        public string? Name { get; set; }       
    }
}
