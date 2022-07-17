namespace HouseRent.Model
{
    public enum AmenitiesType
    {
        Kitchen, Washing, Technology ,Parking, Facilities
    }
    public class Amenities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public AmenitiesType Type { get; set; }
    }
}
