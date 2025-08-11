using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems
{
     internal class Problem1
    {
        public static void Run()
        {
            var products = new List<string> {"Laptop", "Mouse" , "Keyboard", "Monitor" , "Speaker"};
            var result = products.Where(p => p.StartsWith("M"));
            Console.WriteLine("products whose names start with the letter M :");

            foreach (var product in result)
            {
                Console.WriteLine(product);
            }
        }
    }
}
