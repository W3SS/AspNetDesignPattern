using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            var products=productService.GetAllProductsIn(1);
            foreach (var p in products)
                Console.WriteLine("Name={0},Price={1},Count={2}", p.Name, p.Price, p.Count);
            Console.Read();
        }
    }
}
