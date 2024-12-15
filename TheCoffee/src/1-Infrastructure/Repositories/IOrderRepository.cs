using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.Domain.Model.Order;
using TheCoffee.src.User_Interface.Contracts.Requests;

namespace TheCoffee.src.Infrastructure.Repositories
{
    public interface IOrderRepository
    {
        ICollection<Order> GetOrders();
        IQueryable<Order> GetAllOrders();
        ICollection<Order> GetFilteredOrders(GetOrdersQuery filter);
        Order GetOrder(int id);
        Order AddOrder([FromBody] Order order);
        Order? UpdateOrder([FromBody] Order order);
    }
}
