using FakeItEasy;
using HouseRent.src.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using HouseRent.Model;
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
