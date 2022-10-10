using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OCL.Products.Models;

namespace OCL.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Product> GetProducts()
        {
            return Product.GetProducts();
        }
    }
}
