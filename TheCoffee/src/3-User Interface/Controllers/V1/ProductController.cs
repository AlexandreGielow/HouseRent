using TheCoffee.src.User_Interface.Contracts.V1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.Domain.Model.Products;
using TheCoffee.src.Application.Service;
using TheCoffee.src.User_Interface.Contracts.Requests;


namespace TheCoffee.Controllers
{
    [Authorize]
    [ApiController]
    [Route("")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService propertyService)
        {
            _productService = propertyService;
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.ProductRoutes.GetProducts)]
        public async Task<ActionResult<ICollection<Product>>> GetActiveProducts()
        {
            return Ok(_productService.GetProducts());
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.ProductRoutes.GetProductsCharacteristics)]
        public async Task<ActionResult<ICollection<Characteristic>>> GetProductsCharacteristics()
        {
            return Ok(_productService.GetProductsCharacteristics());
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.ProductRoutes.GetProductsAndCharacteristics)]
        public async Task<ActionResult<ICollection<Product>>> GetProductsAndCharacteristics(GetProductQuery filter)
        {
            return Ok(_productService.GetProductsAndCharacteristics(filter));
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.ProductRoutes.GetFilteredProducts)]
        public async Task<ActionResult<ICollection<Product>>> GetFilteredProducts ([FromQuery] GetProductQuery filter)
        {
            return Ok(_productService.GetProductsByFilter(filter));
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.ProductRoutes.GetFilteredProducts+"/{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var property = _productService.GetProductById(id);
            if (property == null)
            {
                return NotFound();
            }
            return Ok(property);
        }

        [HttpPost(ApiRoutes.ProductRoutes.PostProduct)]
        public async Task<ActionResult<ICollection<Product>>> AddProduct(Product product)
        {
            return Ok(_productService.AddProduct(product));
        }

        [HttpPut(ApiRoutes.ProductRoutes.PutProduct)]
        public async Task<ActionResult<ICollection<Product>>> UpdateProduct(Product property)
        {
            return Ok(_productService.UpdateProduct(property));
        }
    }

}
