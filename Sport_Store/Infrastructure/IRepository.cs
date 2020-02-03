using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sport_Store.Models;

namespace Sport_Store.Infrastructure
{
    public interface IRepository
    {
            IEnumerable<Product> Products { get; }
            void AddProduct(Product product);
    }
}
