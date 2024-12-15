using System.ComponentModel.DataAnnotations;

namespace TheCoffee.src.Domain.Model.Property
{
    public class Photos
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Store.Store Store { get; set; }
    }
}
