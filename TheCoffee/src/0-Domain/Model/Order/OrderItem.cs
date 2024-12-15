using System.Text.Json.Serialization;
using TheCoffee.src.Domain.Model.Products;

namespace TheCoffee.src.Domain.Model.Order
{
    public class OrderItem
    {
        public int Id { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }          
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }

    }
}
