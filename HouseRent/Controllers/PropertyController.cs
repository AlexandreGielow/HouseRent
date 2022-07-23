using HouseRent.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HouseRent.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PropertyController : Controller
    {
        private readonly HouseRentContext _context;
        public PropertyController(HouseRentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Property>>> GetActiveProperties()
        {
            return Ok(await _context.Properties.Where(p => p.Status == PropertyStatus.Active).ToListAsync()) ;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Property>>> Get(int id)
        {
            var Property = await _context.People.FindAsync(id);
            if (Property == null)
            {
                return BadRequest("Property not found");
            }
            return Ok(Property);
        }

        [HttpPost]
        public async Task<ActionResult<List<Property>>> AddProperty(Property property)
        {
            if (ModelState.IsValid)
            {
                _context.Properties.Add(property);
                _context.SaveChanges();
            }
            var result = await _context.People.ToListAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<List<Property>>> UpdateProperty(Property Property)
        {
            var result = await _context.People.Where(p => p.Id == Property.Id).ToListAsync();
            if (result == null)
            {
                return BadRequest("Property not found");
            }

            return Ok(result);
        }
    }

}
