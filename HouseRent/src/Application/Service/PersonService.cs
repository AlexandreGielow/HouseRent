using HouseRent.Model;
using HouseRent.src.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent.src.Application.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        public  Person GetPersonById(int i)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.Get(i);
        }
        public Person UpdatePerson(Person p)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.UpdatePerson(p);
        }
        public Person AddPerson(Person p)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.AddPerson(p);
        }
        public ActionResult<dynamic> Authenticate(Person person)
        {
            Person p = _repository.AuthenticateAsync(person);
            if (p != null)
            {
                var token = TokenService.GenerateTokens(p);
                person.Password = null;
                return new
                {
                    person,
                    token
                };
            }
            else
                return null;
        }
    }
}
