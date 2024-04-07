using HouseRent.Model;
using HouseRent.src.User_Interface.Contracts.Requests;

namespace HouseRent.src.Application.Service
{
    public interface IPropertyService
    {
        public ICollection<Property> GetProperties();
        public Property GetPropertiesById(int id);
        public ICollection<Property> GetPropertiesByFilter(GetPropertiesQuery filter);
        public Property AddProperty(Property property);
        public Property UpdateProperty(Property property);
        public double CalculateRentalTax(Property property);
    }
}
