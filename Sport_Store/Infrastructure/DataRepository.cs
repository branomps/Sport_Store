using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sport_Store.Models;

namespace Sport_Store.Infrastructure
{
    public class DataRepository : IRepository
    {
        // private List<Product> data = new List<Product>();

        private DataContext context;
        public DataRepository(DataContext dataContext)
        {
            context = dataContext;
        }
        public IEnumerable<Product> Products => context.Products;
        public void AddProduct (Product product)
        {
            this.context.Add(product);
            this.context.SaveChanges();
        }
    }
}