using HouseRent.src.Domain.Model.Property;
using HouseRent.src.Infrastructure.Repositories;
using HouseRent.src.User_Interface.Contracts.Requests;


namespace HouseRent.src.Application.Service
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _repository;

        public PropertyService(IPropertyRepository repository)
        {
            _repository = repository;
        }

        public  ICollection<Property> GetProperties()
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetActiveProperties();
        }
        public Property GetPropertiesById(int i)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetProperty(i);
        }
        public ICollection<Property> GetPropertiesByFilter(GetPropertiesQuery f)
        {
            
            
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetFilteredProperties(f);
        }

        public Property AddProperty(Property property)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.AddProperty(property);
        }
        public Property UpdateProperty(Property property)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.UpdateProperty(property);
        }

        public double CalculateRentalTax (Property property)
        {
            if (property.RentalType == RentalType.LongTerm){
                return property.Value * 0.05;
            }
            else
            {
                return property.Value * 0.08;
            }
        }

    }
}
