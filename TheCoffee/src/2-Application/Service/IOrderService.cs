using TheCoffee.src.Domain.Model.Order;
using TheCoffee.src.User_Interface.Contracts.Requests;

namespace TheCoffee.src.Application.Service
{
    public interface IOrderService
    {
        public ICollection<Order> GetOrders();
        public IQueryable<Order> GetAllOrders();
        public Order GetOrderById(int id);
        public ICollection<Order> GetOrdersByFilter(GetOrdersQuery filter);
        public Order AddOrder(Order order);
        public Order UpdateOrder(Order order);
    }
}
