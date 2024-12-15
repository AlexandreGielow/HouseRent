using TheCoffee.src.Domain.Model.Person;
using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.User_Interface.Contracts.DTOs;

namespace TheCoffee.src.Infrastructure.Repositories
{
    public interface IPersonRepository
    {
        Person? Get(int id);
        Person? GetByEmail(string email);

        Person? AddPerson(Person person);

        Person? UpdatePerson(Person person);
    }
}
