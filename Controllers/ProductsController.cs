using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private static readonly string[] Products =
        {
            "Iphone 14","IPhone 15","IPhone 16"
        };

        //localhost:5000/api/products => GET
        [HttpGet]
        public string[] GetProducts()
        {
            return Products;
        }

        //localhost:5000/api/products/1 => GET
        [HttpGet("{id}")]
        public string GetProducts(int id)
        {
            return Products[id];
        }
    }
}
