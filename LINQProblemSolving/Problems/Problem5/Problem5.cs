using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQProblemSolving.Problems.Problem5
{
    internal class Problem5
    {
        public static void Run()
        {
            //You have a list of Customer objects, each with a list of Orders.
            //Write a LINQ query to get a flattened list of all orders,
            //including the customer name and order total.

            var result = Customer.GetAllCustomers().SelectMany(x => x.Orders, (name, order) => new
            {
                CName = name.Name,
               OrderTotal = order.Total

            });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.CName}:\t{item.OrderTotal}");
                
            }
            Console.WriteLine("\n-----------SQL Like---------------\n");
            var result2 = from customer in Customer.GetAllCustomers()
                          from order in customer.Orders
                          select new
                          {
                              CName = customer.Name,
                              OrderTotal = order.Total

                          };

            foreach (var item in result2)
            {
                Console.WriteLine($"{item.CName}:\t{item.OrderTotal}");

            }

        }
    }
}
