using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem9
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetAllProducts()
        {
            return new List<Product>
        {
            new Product { Id = 1, Category = "Electronics", Price = 199.99m },
            new Product { Id = 2, Category = "Clothing", Price = 49.99m },
            new Product { Id = 3, Category = "Books", Price = 9.99m },
            new Product { Id = 4, Category = "Electronics", Price = 299.99m }
        };
        }
    }
}
