using TheCoffee.src.Domain.Model.Person;
using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.User_Interface.Contracts.DTOs;

namespace TheCoffee.src.Application.Service
{
    public interface IPersonService
    {
        public Person? GetPersonById(int id);
        public Person? UpdatePerson([FromBody] Person person);
        public Person? AddPerson([FromBody] Person person);
        public AuthenticationResult RegisterAsync(string email, string password, string Name, string SureName);
    }
}
