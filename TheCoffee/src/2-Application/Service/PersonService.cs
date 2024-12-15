using TheCoffee.src.Domain.Model.Person;
using TheCoffee.src.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.User_Interface.Contracts.DTOs;

namespace TheCoffee.src.Application.Service
{
    public class PersonService(IPersonRepository repository) : IPersonService
    {
        private readonly IPersonRepository _repository = repository;

        public Person? GetPersonById(int i)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.Get(i);
        }
        public Person? UpdatePerson(Person p)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.UpdatePerson(p);
        }
        public Person? AddPerson(Person p)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.AddPerson(p);
        }
        public AuthenticationResult RegisterAsync(string email, string password, string Name, string SureName)
        {
            var existingUser = _repository.GetByEmail(email);
            if (existingUser != null)
            {
                if (existingUser.ValidUser == false)
                {
                    return new AuthenticationResult
                    {
                        Error = [$"This user with the email {email} already exist, but are not validated"]
                    };
                }
                else
                {
                    return new AuthenticationResult
                    {
                        Error = [$"This user with the email {email} already exist!"]
                    };
                } 
            }
            var NewUser = new Person()
            {
                Email = email, Name = Name, SureName = SureName, PersonType = PersonType.Visitor
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
                    Error = [$"Error Creating the account, please reach out the admin."]
                };
            }
        }
    }
}
