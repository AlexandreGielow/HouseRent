using Microsoft.AspNetCore.Mvc;
using HouseRent.Model;
using Microsoft.AspNetCore.Authorization;
using HouseRent.src.Application.Service;

namespace HouseRent.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        [HttpGet("{id}")]
        public async Task<ActionResult<ICollection<Person>>> Get(int id)
        {
            return Ok(_personService.GetPersonById(id));
        }
        [AllowAnonymous]
        [HttpPost]        
        public async Task<ActionResult<ICollection<Person>>> AddPerson(Person person)
        {
            return Ok(_personService.AddPerson(person));
        }

        [HttpPut]
        public async Task<ActionResult<ICollection<Person>>> UpdatePerson(Person person)
        {            
            return Ok(_personService.UpdatePerson(person));
        }


        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] Person model)
        {
            _personService.Authenticate(model);
            return new
            {
                //person,
               // token
            };

        }
    }
}
