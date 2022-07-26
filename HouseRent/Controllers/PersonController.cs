using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HouseRent.Data;
using HouseRent.Model;


namespace HouseRent.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonController : Controller
    {

        private readonly HouseRentContext _context;

        public PersonController(HouseRentContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Person>>> Get()
        {            
            return Ok(await _context.People.ToListAsync());
        }

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
    }
}
