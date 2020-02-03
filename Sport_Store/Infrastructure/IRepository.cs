using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_Store.Infrastructure
{
    interface IRepository
    {
        public interface IRepository
        {
            IEnumerable<Product> Products { get; }
            void AddProduct(Product product);
        }
    }
}
