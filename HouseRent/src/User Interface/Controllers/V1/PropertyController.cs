using HouseRent.Model;
using HouseRent.src.Application.Service;
using HouseRent.src.User_Interface.Contracts.Requests;
using HouseRent.src.User_Interface.Contracts.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace HouseRent.Controllers
{
    [Authorize]
    [ApiController]
    [Route("")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.PropertiesRoutes.GetProperties)]
        public async Task<ActionResult<ICollection<Property>>> GetActiveProperties()
        {
            return Ok(_propertyService.GetProperties());
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.PropertiesRoutes.GetFilteredProperties)]
        public async Task<ActionResult<ICollection<Property>>> GetFilteredProperties(GetPropertiesQuery filter)
        {
            return Ok(_propertyService.GetPropertiesByFilter(filter));
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.PropertiesRoutes.GetFilteredProperties+"/{id}")]
        public async Task<ActionResult<Property>> Get(int id)
        {
            return Ok(_propertyService.GetPropertiesById(id));
        }

        [HttpPost(ApiRoutes.PropertiesRoutes.PostPropertioes)]
        public async Task<ActionResult<ICollection<Property>>> AddProperty(Property property)
        {
            return Ok(_propertyService.AddProperty(property));
        }

        [HttpPut(ApiRoutes.PropertiesRoutes.PutPropertioes)]
        public async Task<ActionResult<ICollection<Property>>> UpdateProperty(Property property)
        {
            return Ok(_propertyService.UpdateProperty(property));
        }
    }

}
