﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sport_Store.Models;

namespace Sport_Store.Infrastructure
{
    public class DataRepository : IRepository
    {
        private List<Product> data = new List<Product>();
        public IEnumerable<Product> Products => data;
        public void AddProduct (Product product)
        {
            this.data.Add(product);
        }
    }
}