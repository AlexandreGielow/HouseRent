using HouseRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent.src.Application.Service
{
    public interface IPersonService
    {
        public Person GetPersonById(int id);

        public Person UpdatePerson(Person person);

        public Person AddPerson(Person person);

        public ActionResult<dynamic> Authenticate([FromBody] Person person);

    }
}
