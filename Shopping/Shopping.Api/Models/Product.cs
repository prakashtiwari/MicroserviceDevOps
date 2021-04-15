﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Api.Models
{
    public class Product
    {
        [BsonId]//Unique
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public string Description { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }

    }
}
