using HouseRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent.src.Infrastructure.Repositories
{
    public interface IPersonRepository
    {
        Person Get(int id);

        Person AddPerson(Person person);

        Person UpdatePerson(Person person);

        Person AuthenticateAsync([FromBody] Person person);

    }
}
