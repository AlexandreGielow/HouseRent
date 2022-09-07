using System.ComponentModel.DataAnnotations;


namespace HouseRent.Model
{
    public enum AmenitiesType
    {
        Kitchen, Washing, Bathing, Technology ,ParkingFacilities
    }
    public class Amenities
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }        
        public AmenitiesType Type { get; set; }
        

        public  Property Property { get; set; }
    }
}
