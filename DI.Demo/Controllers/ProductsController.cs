using DI.Demo.Model;
using DI.Demo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DI.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsService productsService = new ProductsService();       

        [HttpGet]
        public List<Product> Get()
        {
            return productsService.GetProductsFromDatabase();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productsService.GetProductById(id);
        }
    }
}
