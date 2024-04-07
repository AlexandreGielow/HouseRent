using FakeItEasy;
using HouseRent.src.Domain.Model.Property;
using Xunit;

using HouseRent.src.Domain.Model.Person;
using HouseRent.src.Application.Service;
using FluentAssertions;

namespace HouseRent.Test.Unit.PropertyT
{
    public class PropertyTests
    {
        private readonly IPropertyService _propertyService;
        public PropertyTests() {
            _propertyService = A.Fake<IPropertyService>();
        }

        [Fact]
        public void PropertyService_CalculateTax_ReturnValue()
        {
            //Arrange
            var property = A.Fake<Property>();
            property.Value = 1000;
            property.RentalType = RentalType.ShortTerm;
            //Act
            var result = _propertyService.CalculateRentalTax(property);
            //Assert
            result.Should().BeGreaterThan(0);
        }
    }
}
