using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HouseRent.Model;
using Microsoft.AspNetCore.Authorization;
using HouseRent.Services;

namespace HouseRent.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonController : Controller
    {

        private readonly HouseRentContext _context;

        public PersonController(HouseRentContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<ICollection<Person>>> Get()
        {            
            return Ok(await _context.People.ToListAsync());
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<ICollection<Person>>> Get(int id)
        {
            var person = await _context.People.FindAsync(id);
            if(person == null)
            {
                return BadRequest("Person not found");
            }
            return Ok(person);
        }
        [AllowAnonymous]
        [HttpPost]        
        public async Task<ActionResult<ICollection<Person>>> AddPerson(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
            }
            var result = await _context.People.ToListAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ICollection<Person>>> UpdatePerson(Person person)
        {
            var result = await _context.People.Where(p => p.Id == person.Id).ToListAsync();
            if (result == null)
            {
                return BadRequest("Person not found");
            }
            
            return Ok(result);
        }


        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] Person model)
        {
            var person = _context.People.Where(p => (p.Email.ToLower() == model.Email.ToLower()) && (p.Password == model.Password)).FirstOrDefault();
            if (person == null)
            {
                return NotFound("Person not found");
            }
            var token = TokenService.GenerateTokens(person);
            person.Password = null;
            return new
            {
                person,
                token
            };

        }
    }
}
