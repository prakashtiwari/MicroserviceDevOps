using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
        new Product()
        {
        Name="IPhone X",
        Description="This product is the best in the market",
        Price=100.20M,
        Category="Smart Phone"
        },
        new Product()
        {
        Name="Samsung 10",
        Description="This product is the best",
        Price=100.20M,
        Category="Smart Phone"
        },
        new Product()
        {
        Name="IPhone X",
        Description="This product is the best",
        Price=100.20M,
        Category="Smart Phone"
        },
        new Product()
        {
        Name="LG Nexus",
        Description="This product is the best",
        Price=100.20M,
        Category="Smart Phone"
        },
         new Product()
        {
        Name="HTC",
        Description="This product is the best",
        Price=1100.20M,
        Category="Smart Phone"
        }
        };

    }
}
