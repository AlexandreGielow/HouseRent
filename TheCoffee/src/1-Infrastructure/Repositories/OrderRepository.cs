using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TheCoffee.src.Domain.Model.Order;
using TheCoffee.src.Domain.Model.Store;
using TheCoffee.src.Infrastructure.Data;
using TheCoffee.src.User_Interface.Contracts.Requests;

namespace TheCoffee.src.Infrastructure.Repositories
{
    public class OrderRepository : Controller, IOrderRepository
    {
        private readonly TheCoffeeContext _context;
        public OrderRepository(TheCoffeeContext context)
        {
            _context = context;
        }

        public  ICollection<Order> GetOrders()
        {           
            return _context.Orders.ToList();
        }

        public IQueryable<Order> GetAllOrders()
        {
            return _context.Orders.Where(p => p.OrderStatus == OrderStatus.Ready).AsQueryable();
        }

        public ICollection<Order> GetFilteredOrders(GetOrdersQuery filter)
        {
            return [.. _context.Orders.Where(p => p.OrderStatus == filter.OrderStatus)];
        }

        public Order GetOrder(int id)
        {
            var Property = _context.Orders
                .Where(p => p.Id == id).First();
            if (Property == null)
            {
                return null;
            }
            return Property;
        }
        public Order AddOrder(Order property)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(property);
                _context.SaveChanges();
            }
            var result = _context.Orders.ToList().Last();
            return result;
        }

        public Order? UpdateOrder(Order Property)
        {
            var result = _context.Orders.Where(p => p.Id == Property.Id)
                .ToList().Last();
            if (result == null)
            {
                return null;
            }
            _context.Update(Property);
            _context.SaveChanges();
            result = _context.Orders.ToList().Last();
            return result;
        }

    }
}
