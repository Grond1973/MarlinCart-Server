﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarlinCart.Common
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _description;
        private decimal _price;

        public Product()
        {
            _id = 0;
            _name = String.Empty;
            _description = String.Empty;
            _price = 0m;
        }
        public Product(int id, string name, string description, decimal price)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public decimal Price { get => _price; set => _price = value; }
    }
}