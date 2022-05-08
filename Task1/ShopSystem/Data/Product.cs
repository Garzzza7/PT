﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ShopSystem.Data
{
    internal class Product:IProduct
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(int _id, double _price, Category _category)
        {
            Id = _id;
            Price = _price;
            Category = _category;
        }
    }
}
