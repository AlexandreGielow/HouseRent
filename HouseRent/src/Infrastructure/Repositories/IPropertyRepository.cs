using HouseRent.src.Domain.Model.Property;
using HouseRent.src.User_Interface.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent.src.Infrastructure.Repositories
{
    public interface IPropertyRepository
    {
        ICollection<Property>  GetActiveProperties();
        ICollection<Property> GetFilteredProperties(GetPropertiesQuery filter);
        Property GetProperty(int id);
        Property AddProperty([FromBody] Property property);
        Property? UpdateProperty([FromBody] Property Property);
    }
}
