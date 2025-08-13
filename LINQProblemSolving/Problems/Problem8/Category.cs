using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem8
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Category> GetAllCategories()
        {
            return new List<Category>
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Clothing" },
            new Category { Id = 3, Name = "Books" }
        };
        }
    }
}
