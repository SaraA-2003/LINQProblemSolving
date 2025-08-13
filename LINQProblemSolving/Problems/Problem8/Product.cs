using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem8
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public static List<Product> GetAllProducts()
        {
            return new List<Product>
        {
            new Product { Id = 1, CategoryId = 1 },
            new Product { Id = 2, CategoryId = 2 },
            new Product { Id = 3, CategoryId = 1 },
            new Product { Id = 4, CategoryId = 3 }
        };
        }
    }
}
