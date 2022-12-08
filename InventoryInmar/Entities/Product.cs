﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryInmar.Entities
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string productName,decimal price,string description)
        {
            ProductName = productName;
            Price = price;
            Description = description;
        }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
