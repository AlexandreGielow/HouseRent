using HouseRent.src.Domain.Model.Property;

namespace HouseRent.src.User_Interface.Contracts.Requests
{
    public class GetPropertiesQuery
    {
        public string Name { get; set; }
        public RentalType RentalType { get; set; }
        public double Value { get; set; }
        public int Size { get; set; }
        public int Rooms { get; set; }
        public PropertyType PropertyType { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Neighborhood { get; set; }
    }
}
