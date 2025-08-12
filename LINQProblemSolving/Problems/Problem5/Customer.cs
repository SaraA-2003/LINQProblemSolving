using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem5
{
    using LINQProblemSolving.Problems.Problem2;
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public static List<Customer> GetAllCustomers()
        {
            return new List<Customer>
        {
            new Customer
            {
                Name = "Alice",
                Orders = new List<Order>
                {
                    new Order { OrderId = 1, Total = 100.50m },
                    new Order { OrderId = 2, Total = 200.00m }
                }
            },
            new Customer
            {
                Name = "Bob",
                Orders = new List<Order>
                {
                    new Order { OrderId = 3, Total = 50.00m }
                }
            },
            new Customer
            {
                Name = "Charlie",
                Orders = new List<Order>()
            }
        };
        }
    }

}
