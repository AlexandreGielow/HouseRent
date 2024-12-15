using TheCoffee.src.Application.Service;
using TheCoffee.src.User_Interface.Contracts.Requests;
using TheCoffee.src.User_Interface.Contracts.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.Domain.Model.Store;


namespace TheCoffee.Controllers
{
    [Authorize]
    [ApiController]
    [Route("")]
    public class StoreController : Controller
    {
        private readonly IStoreService _propertyService;

        public StoreController(IStoreService propertyService)
        {
            _propertyService = propertyService;
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.StoreRoutes.GetStores)]
        public async Task<ActionResult<ICollection<Store>>> GetActiveStores()
        {
            return Ok(_propertyService.GetStores());
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.StoreRoutes.GetFilteredStores)]
        public async Task<ActionResult<ICollection<Store>>> GetFilteredStores (GetStoresQuery filter)
        {
            return Ok(_propertyService.GetStoreByFilter(filter));
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.StoreRoutes.GetFilteredStores+"/{id}")]
        public async Task<ActionResult<Store>> Get(int id)
        {
            var property = _propertyService.GetStoreById(id);
            if (property == null)
            {
                return NotFound();
            }
            return Ok(property);
        }

        [HttpPost(ApiRoutes.StoreRoutes.PostStore)]
        public async Task<ActionResult<ICollection<Store>>> AddProperty(Store property)
        {
            return Ok(_propertyService.AddStore(property));
        }

        [HttpPut(ApiRoutes.StoreRoutes.PutStore)]
        public async Task<ActionResult<ICollection<Store>>> UpdateProperty(Store property)
        {
            return Ok(_propertyService.UpdateStore(property));
        }
    }

}
