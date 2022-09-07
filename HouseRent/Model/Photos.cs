using System.ComponentModel.DataAnnotations;

namespace HouseRent.Model
{
    public class Photos
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Property Property { get; set; }
    }
}
