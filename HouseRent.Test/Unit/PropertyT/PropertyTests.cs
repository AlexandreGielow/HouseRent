using FakeItEasy;
using HouseRent.src.Application.Service;

namespace HouseRent.Test.Unit.PropertyT
{
    public class PropertyTests
    {
        private readonly IStoreService _propertyService;
        public PropertyTests() {
            _propertyService = A.Fake<IStoreService>();
        }

    }
}
