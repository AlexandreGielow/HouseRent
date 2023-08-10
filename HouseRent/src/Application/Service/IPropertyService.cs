using HouseRent.Model;

namespace HouseRent.src.Application.Service
{
    public interface IPropertyService
    {
        public ICollection<Property> GetProperties();
        public Property GetPropertiesById(int id);
        public ICollection<Property> GetPropertiesByFilter(string filter);
        public Property AddProperty(Property property);
        public Property UpdateProperty(Property property);
    }
}
