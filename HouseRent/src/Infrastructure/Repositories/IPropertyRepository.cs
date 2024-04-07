using HouseRent.Model;
using HouseRent.src.User_Interface.Contracts.Requests;

namespace HouseRent.src.Infrastructure.Repositories
{
    public interface IPropertyRepository
    {
        ICollection<Property>  GetActiveProperties();
        ICollection<Property> GetFilteredProperties(GetPropertiesQuery filter);
        Property GetProperty(int id);
        Property AddProperty(Property property);
        Property UpdateProperty(Property Property);
    }
}
