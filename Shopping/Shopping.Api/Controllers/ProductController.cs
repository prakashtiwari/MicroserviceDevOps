using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.Api.Data;
using Shopping.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {

        private readonly ILogger<ProductController> logger;
        private readonly ProductContext _productContext;
        public ProductController(ILogger<ProductController> _logger, ProductContext productContext)
        {
            _productContext = productContext;
            logger = _logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {

            return await _productContext.Products.Find<Product>(p => true).ToListAsync();
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(i => new Product
            //{
            //    Name = "Asp"
            //}
            //).ToArray();

        }

    }
}
