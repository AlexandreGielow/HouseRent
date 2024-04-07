using Microsoft.AspNetCore.Mvc;
using HouseRent.Model;
using Microsoft.AspNetCore.Authorization;
using HouseRent.src.Application.Service;
using HouseRent.src.User_Interface.Contracts.V1;

namespace HouseRent.Controllers
{
    [Authorize]
    [ApiController]
    [Route("")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet(ApiRoutes.PersonRoutes.GetPerson+"/{id}")]
        public async Task<ActionResult<ICollection<Person>>> Get(int id)
        {
            return Ok(_personService.GetPersonById(id));
        }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.PersonRoutes.PostPerson)]        
        public async Task<ActionResult<ICollection<Person>>> AddPerson(Person person)
        {
            return Ok(_personService.AddPerson(person));
        }

        [HttpPut(ApiRoutes.PersonRoutes.PutPerson)]
        public async Task<ActionResult<ICollection<Person>>> UpdatePerson(Person person)
        {            
            return Ok(_personService.UpdatePerson(person));
        }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.PersonRoutes.AuthPerson)]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] Person person)
        {
            return Ok(_personService.Authenticate(person));           
        }
    }
}
