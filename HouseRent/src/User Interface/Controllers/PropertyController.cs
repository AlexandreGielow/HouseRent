using HouseRent.Model;
using HouseRent.src.Application.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace HouseRent.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;

        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<ICollection<Property>>> GetActiveProperties()
        {
            return Ok(_propertyService.GetProperties());
        }

        [AllowAnonymous]
        [HttpGet("/api/Property/search/{filter}")]
        public async Task<ActionResult<ICollection<Property>>> GetFilteredProperties(string filter)
        {
            return Ok(_propertyService.GetPropertiesByFilter(filter));
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> Get(int id)
        {
            return Ok(_propertyService.GetPropertiesById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ICollection<Property>>> AddProperty(Property property)
        {
            return Ok(_propertyService.AddProperty(property));
        }

        [HttpPut]
        public async Task<ActionResult<ICollection<Property>>> UpdateProperty(Property property)
        {
            return Ok(_propertyService.UpdateProperty(property));
        }
    }

}
