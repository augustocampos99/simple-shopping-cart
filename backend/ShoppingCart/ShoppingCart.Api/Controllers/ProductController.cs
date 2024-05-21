using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces.Services;
using ShoppingCart.Domain.Entities;

namespace ShoppingCart.Api.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private readonly IProductServiceApp _productServiceApp;

        public ProductController(IProductServiceApp productServiceApp)
        {
            _productServiceApp = productServiceApp;
        }

        [HttpGet("")]
        public async Task<IActionResult>  GetAll()
        {
            var result = await _productServiceApp.GetAll(0, 100);

            if(result.Success) {
                return Ok(result.Result);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
