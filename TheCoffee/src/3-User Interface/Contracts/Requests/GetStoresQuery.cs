using TheCoffee.src.Domain.Model.Property;
using TheCoffee.src.Domain.Model.Store;

namespace TheCoffee.src.User_Interface.Contracts.Requests
{
    public class GetStoresQuery
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Size { get; set; }
        public int Rooms { get; set; }
        public StoreType PropertyType { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Neighborhood { get; set; }
    }
}
