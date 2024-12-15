using TheCoffee.src.Domain.Model.Order;
using TheCoffee.src.Infrastructure.Repositories;
using TheCoffee.src.User_Interface.Contracts.Requests;


namespace TheCoffee.src.Application.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository) => _repository = repository;

        public ICollection<Order> GetOrders()
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetOrders();
        }

        public IQueryable<Order> GetAllOrders()
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetAllOrders();
        }

        public Order GetOrderById(int i)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetOrder(i);
        }
        public ICollection<Order> GetOrdersByFilter(GetOrdersQuery f)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetFilteredOrders(f);
        }

        public Order AddOrder(Order order)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.AddOrder(order);
        }
        public Order UpdateOrder(Order order)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.UpdateOrder(order);
        }
    }
}
