using System.ComponentModel.DataAnnotations;


namespace HouseRent.src.Domain.Model.Property
{
    public class PropertyHighlights
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Property Property { get; set; }

    }
}
