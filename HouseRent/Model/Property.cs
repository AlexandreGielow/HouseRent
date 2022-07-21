using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace HouseRent.Model
{
    public enum PropertyType
    {
        RoomInHouse, House, Apartment
    }
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }        
        public Address Adress { get; set; }
        public int PersonId { get; set; }
        public Person Owner { get; set; }
        public DateTime? StartRent { get; set; }
        public DateTime? EndRent    { get; set; }
        public int Size { get; set; }
        public int Rooms  { get; set; }
        public bool Furnished { get; set; }
        public int Accommodates { get; set; }
        public string Description { get; set; }
        public PropertyType Type { get; set; }
        public List<PropertyHighlights>? Highlights { get; set; }
        public List<PropertyRulesAcessibility>? RulesAcessibilitiy { get; set; }
        public List<Amenities>? Amenities { get; set; }

    }
}
