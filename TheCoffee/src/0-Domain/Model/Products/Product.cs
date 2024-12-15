using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TheCoffee.src.Domain.Model.Order;

namespace TheCoffee.src.Domain.Model.Products
{
    public enum ProductStatus
    {
        Inactive, Active, OutOfStock
    }

    public enum UnitOfMeasure
    {
        kg,g,lb,l,ml
    }
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }       
        public required ProductStatus Status { get; set; }
        public ICollection<Characteristic>? Characteristics { get; set; }
        [JsonIgnore]
        public ICollection<OrderItem>? OrderItem { get; set; }
        public required UnitOfMeasure UnitOfMesure { get; set; }
        public required float Value { get; set; }

    }
}
