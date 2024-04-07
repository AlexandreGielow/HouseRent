using HouseRent.src.Domain.Model.Person;
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
        public ActionResult<dynamic> Authenticate([FromBody] Person person)
        {
            Person p = _repository.AuthenticateAsync(person);
            if (p != null)
            {
                var token = TokenService.GenerateTokens(p);
                p.Password = "";
                return new
                {
                    p,
                    token
                };
            }
            else
                return "";
        }
        public async Task<Domain.Model.Person.AuthenticationResult> RegisterAsync(string email, string password, string Name, string SureName)
        {
            var existingUser = _repository.GetByEmail(email);
            if (existingUser != null)
            {
                if (existingUser.ValidUser == false)
                {
                    return new AuthenticationResult
                    {
                        Error = new[] { $"This user with the email {email} already exist, but are not validated" }
                    };
                }
                else
                {
                    return new AuthenticationResult
                    {
                        Error = new[] { $"This user with the email {email} already exist!" }
                    };
                } 
            }
            var NewUser = new Person()
            {
                Email = email, Password = password, Name = Name, SureName = SureName
            };
            var CreatedUser = _repository.AddPerson(NewUser);

            if(CreatedUser != null)
            {
                return new AuthenticationResult
                {
                    Success = true
                };
            }
            else
            {
                return new AuthenticationResult
                {
                    Error = new[] { $"Error Creating the account, please reach out the admin." }
                };
            }
        }
    }
}
