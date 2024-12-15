using TheCoffee.src.Application.Service;
using TheCoffee.src.User_Interface.Contracts.Requests;
using TheCoffee.src.User_Interface.Contracts.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.Domain.Model.Order;

namespace TheCoffee.Controllers
{
    [Authorize]
    [ApiController]
    [Route("")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet(ApiRoutes.OrderRoutes.GetOrders)]
        public async Task<ActionResult<ICollection<Order>>> GetOrders()
        {
            return Ok(_orderService.GetOrders());
        }

        [HttpGet(ApiRoutes.OrderRoutes.GetAllOrders)]
        public async Task<ActionResult<ICollection<Order>>> GetAllOrders()
        {
            return Ok(_orderService.GetAllOrders());
        }

        [HttpGet(ApiRoutes.OrderRoutes.GetFilteredOrders)]
        public async Task<ActionResult<ICollection<Order>>> GetFilteredOrders(GetOrdersQuery filter)
        {
            return Ok(_orderService.GetOrdersByFilter(filter));
        }

        [HttpGet(ApiRoutes.OrderRoutes.GetFilteredOrders + "/{id}")]
        public async Task<ActionResult<Order>> Get(int id)
        {
            var order = _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost(ApiRoutes.OrderRoutes.PostOrder)]
        public async Task<ActionResult<ICollection<Order>>> AddOrder(Order order)
        {
            return Ok(_orderService.AddOrder(order));
        }

        [HttpPut(ApiRoutes.OrderRoutes.PutOrder)]
        public async Task<ActionResult<ICollection<Order>>> UpdateOrder(Order order)
        {
            return Ok(_orderService.UpdateOrder(order));
        }
    }

}

