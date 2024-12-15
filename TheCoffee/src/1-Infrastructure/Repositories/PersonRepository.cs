using TheCoffee.src.Domain.Model.Person;
using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.Infrastructure.Data;
using TheCoffee.src.User_Interface.Contracts.DTOs;

namespace TheCoffee.src.Infrastructure.Repositories
{
    public class PersonRepository : Controller,IPersonRepository
    {
        private readonly TheCoffeeContext _context;
        public PersonRepository(TheCoffeeContext context)
        {
            _context = context;
        }
        public  Person? Get(int id)
        {
            var person =  _context.People.Find(id);
            if (person == null)
            {
                return null;
            }
            return person;
        }

        public Person? GetByEmail(string email)
        {
            var person = _context.People.Where(p => p.Email == email).First();
            if (person == null)
            {
                return null;
            }
            return person;
        }

        public  Person AddPerson(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
            }
            var result =  _context.People.Last();
            return result;
        }

        public Person? UpdatePerson(Person person)
        {
            var result = _context.People.Where(p => p.Id == person.Id).First();
            if (result == null)
            {
                return null;
            }
            _context.Update(person);
            _context.SaveChanges();
            result = _context.People.Where(p => p.Id == person.Id).First();

            return result;
        }
    }
}
