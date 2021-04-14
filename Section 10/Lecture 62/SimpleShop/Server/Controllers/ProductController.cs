using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get()
        {
            List<Product> products = new()
            {
                new Product(1, "Table", 98, Catagory.Furniture),
                new Product(2, "Jeans", 45, Catagory.Cloth),
                new Product(3, "Football", 190, Catagory.Sport),

            };

            return products;
        }
    }
}
