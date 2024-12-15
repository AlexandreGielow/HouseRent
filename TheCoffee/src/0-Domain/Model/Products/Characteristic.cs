using System.ComponentModel.DataAnnotations;

namespace TheCoffee.src.Domain.Model.Products
{
    public class Characteristic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Description { get; set; }
        [Required]
        public required string Value { get; set; }
        public ICollection<Product>? Products { get; set; }
        
    }
}
