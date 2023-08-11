using HouseRent.Model;
using HouseRent.src.Application.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HouseRent.src.Infrastructure.Repositories
{
    public class PersonRepository : Controller,IPersonRepository
    {
        private readonly HouseRentContext _context;
        public PersonRepository(HouseRentContext context)
        {
            _context = context;
        }
        public  Person Get(int id)
        {
            var person =  _context.People.Find(id);
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

        public  Person UpdatePerson(Person person)
        {
            var result = _context.People.Where(p => p.Id == person.Id).First();
            if (result == null)
            {
                return null;
            }

            return result;
        }
        public  Person AuthenticateAsync([FromBody] Person per)
        {
            var person = _context.People.Where(p => (p.Email.ToLower() == per.Email.ToLower()) && (p.Password == per.Password)).FirstOrDefault();
            if (person == null)
            {
                return null;
            }
            else
            {
                return person;
            }
        }
    }
}
