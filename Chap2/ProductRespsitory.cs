using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    public class ProductRespsitory
    {
        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products = new List<Product>();
            products.Add(new Product { Name = "001", Price = 1, Count = 2 });
            products.Add(new Product { Name = "001", Price = 2, Count = 4 });
            products.Add(new Product { Name = "001", Price = 3, Count = 6 });
            return products;
        }
    }
}
