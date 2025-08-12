using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem7
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public static List<Product> GetAllProducts()
        {
            return new List<Product>
        {
            new Product { Id = 1, Category = "Electronics" },
            new Product { Id = 2, Category = "Books" },
            new Product { Id = 3, Category = "Clothing" }
        };
        }
    }

}
