using TheCoffee.src.Domain.Model.Property;
using TheCoffee.src.User_Interface.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheCoffee.src.Infrastructure.Data;
using TheCoffee.src.Domain.Model.Store;

namespace TheCoffee.src.Infrastructure.Repositories
{
    public class StoreRepository : Controller,IStoreRepository
    {
        private readonly TheCoffeeContext _context;
        public StoreRepository(TheCoffeeContext context)
        {
            _context = context;
        }
        public ICollection<Store> GetActiveProperties()
        {
            return [.. _context.Stores.Where(p => p.Status == StoreStatus.Active).Include(a => a.Address)];
        }
        public ICollection<Store> GetFilteredStores(GetStoresQuery filter)
        {
            return  _context.Stores
                .Where(p => p.Status == StoreStatus.Active && p.Address.City.Contains(filter.City))
                .Include(a => a.Address)
                .ToList();
        }

        public Store GetStore(int id)
        {
            var Property =  _context.Stores.Include(a => a.Address)
                .Where(p => p.Id == id)
                .Include(a => a.Address).First();
            if (Property == null)
            {
                return null;
            }
            return Property;
        }
        public Store AddStore(Store store)
        {
            if (ModelState.IsValid)
            {
                _context.Stores.Add(store);
                _context.SaveChanges();
            }
            var result = _context.Stores.ToList().Last();
            return result;
        }

        public Store? UpdateStore(Store store)
        {
            var result = _context.Stores.Where(p => p.Id == store.Id)
                .ToList().Last();
            if (result == null)
            {
                return null;
            }
            _context.Update(store);
            _context.SaveChanges();
            result = _context.Stores.ToList().Last();
            return result;
        }

    }
}
