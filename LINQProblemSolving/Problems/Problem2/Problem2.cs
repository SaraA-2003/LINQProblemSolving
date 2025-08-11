using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem2
{
    internal class Problem2
    {
        public static void Run()
        {
          var orders = new List<Order>
            {
               new Order { OrderId = 1, CustomerName = "Ali", Amount = 250 },
               new Order { OrderId = 2, CustomerName = "Ahmad", Amount = 150 },
               new Order { OrderId = 3, CustomerName = "Ali", Amount = 300 },
               new Order { OrderId = 3, CustomerName = "Haya", Amount = 300 }

            };


            Console.WriteLine("Version 1:");

            var groupResult = orders.GroupBy(x => x.CustomerName);
            Console.WriteLine("CustomerName and total amount spent by each customer:\n");
            foreach(var order in groupResult)
            {
                Console.WriteLine($"{order.Key} - {order.Sum(x => x.Amount)}");
            }

            Console.WriteLine("\nVersion 2:");
            var groupResult2 = orders.GroupBy(o => o.CustomerName)
                .Select(c => new { Name = c.Key, TotalAmount = c.Sum(t => t.Amount) });

            Console.WriteLine("CustomerName and total amount spent by each customer:\n");
            foreach(var order in groupResult2)
            {
                Console.WriteLine($"{order.Name} - {order.TotalAmount}");
            }

           

        }
    }
}
