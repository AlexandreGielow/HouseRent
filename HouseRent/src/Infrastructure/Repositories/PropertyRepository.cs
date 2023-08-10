using HouseRent.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HouseRent.src.Infrastructure.Repositories
{
    public class PropertyRepository : Controller,IPropertyRepository
    {
        private readonly HouseRentContext _context;
        public PropertyRepository(HouseRentContext context)
        {
            _context = context;
        }
        public ICollection<Property> GetActiveProperties()
        {
            return _context.Properties.Where(p => p.Status == PropertyStatus.Active)
                .Include(a => a.Address)
                .ToList();
        }
        public ICollection<Property> GetFilteredProperties(string filter)
        {
            return  _context.Properties
                .Where(p => p.Status == PropertyStatus.Active && (p.Name.Contains(filter) || p.Address.City.Contains(filter)))
                .Include(a => a.Address)
                .ToList();
        }

        public Property GetProperty(int id)
        {
            var Property =  _context.Properties.Include(a => a.Address)
                .Where(p => p.Id == id)
                .Include(a => a.Address).First();
            if (Property == null)
            {
                return null;
            }
            return Property;
        }
        public Property AddProperty(Property property)
        {
            if (ModelState.IsValid)
            {
                _context.Properties.Add(property);
                _context.SaveChanges();
            }
            var result = _context.Properties.ToList().Last();
            return result;
        }

        public Property UpdateProperty(Property Property)
        {
            var result = _context.Properties.Where(p => p.Id == Property.Id)
                .ToList().Last();
            if (result == null)
            {
                return null;
            }
            return result;
        }

    }
}
