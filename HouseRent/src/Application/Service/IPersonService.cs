using HouseRent.src.Domain.Model.Person;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent.src.Application.Service
{
    public interface IPersonService
    {
        public Person GetPersonById(int id);

        public Person UpdatePerson([FromBody] Person person);

        public Person AddPerson([FromBody] Person person);

        public ActionResult<dynamic> Authenticate([FromBody] Person person);

        Task<Domain.Model.Person.AuthenticationResult> RegisterAsync(string email, string password, string Name, string SureName);

    }
}
