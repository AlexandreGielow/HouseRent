using HouseRent.Model;
using HouseRent.Services;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class LoginController : ControllerBase
    {
        private readonly HouseRentContext _context;

        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] Person model)
        {
            var person =  _context.People.Where(p => !(p.Email == model.Email) && (p.Password == model.Password)).FirstOrDefault();
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
