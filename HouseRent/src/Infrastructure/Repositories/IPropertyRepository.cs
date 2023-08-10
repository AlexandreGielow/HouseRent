using HouseRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent.src.Infrastructure.Repositories
{
    public interface IPropertyRepository
    {
       ICollection<Property>  GetActiveProperties();
        ICollection<Property> GetFilteredProperties(string filter);
        Property GetProperty(int id);
        Property AddProperty(Property property);
        Property UpdateProperty(Property Property);
    }
}
