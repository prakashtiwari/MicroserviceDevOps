using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Shopping.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Api.Data
{
    public class ProductContext
    {
        private readonly MongoClient mongoClient;
        private readonly IConfiguration _configuration;
        public IMongoCollection<Product> Products { get; }
        public ProductContext(IConfiguration configuration)
        {
            _configuration = configuration;
                mongoClient = new MongoClient(_configuration["DatabaseSettings:ConnectionString"]);
            var database = mongoClient.GetDatabase(_configuration["DatabaseSettings:DatabaseName"]);
            Products = database.GetCollection<Product>(_configuration["DatabaseSettings:CollectionName"]);
            SeedData(Products, database);
        }

        private static void SeedData(IMongoCollection<Product> productCollectiob,IMongoDatabase database)
        {
            bool existsProduct = productCollectiob.Find(p => true).Any();
            if (!existsProduct)
            {
                productCollectiob.InsertManyAsync(GetConfiguredProducts());
            }
            else
            {
                productCollectiob.DeleteMany(p=>p.Category== "Smart Phone");
                productCollectiob.InsertManyAsync(GetConfiguredProducts());

            }
        }
        private static IEnumerable<Product> GetConfiguredProducts()
        {
        return new List<Product>
        {
        new Product()
        {
            Name = "IPhone X Latest",
        Description = "This product is the best in the market. This is value for money",
        Price = 100.20M,
        Category = "Smart Phone"
        },
        new Product()
        {
            Name = "Samsung 10",
        Description = "This product is the best in the world.",
        Price = 100.20M,
        Category = "Smart Phone"
        },
        new Product()
        {
            Name = "IPhone X",
        Description = "This product is the best",
        Price = 100.20M,
        Category = "Smart Phone"
        },
        new Product()
        {
            Name = "LG Nexus",
        Description = "This product is the best",
        Price = 100.20M,
        Category = "Smart Phone"
        },
         new Product()
        {
            Name = "HTC",
        Description = "This product is the best",
        Price = 1100.20M,
        Category = "Smart Phone"
        }

    };
}
}
}
