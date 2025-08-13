using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem9
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public static List<Customer> GetAllCustomers()
        {
            return new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "Alice",
                Orders = new List<Order>
                {
                    new Order
                    {
                        Id = 101,
                        Items = new List<OrderItem>
                        {
                            new OrderItem { ProductId = 1, Quantity = 2 },
                            new OrderItem { ProductId = 2, Quantity = 1 },
                            new OrderItem { ProductId = 3, Quantity = 6 }
                        }
                    },
                    new Order
                    {
                        Id = 102,
                        Items = new List<OrderItem>
                        {
                            new OrderItem { ProductId = 1, Quantity = 5 }
                        }
                    }
                }
            },
            new Customer
            {
                Id = 2,
                Name = "Bob",
                Orders = new List<Order>
                {
                    new Order
                    {
                        Id = 103,
                        Items = new List<OrderItem>
                        {
                            new OrderItem { ProductId = 2, Quantity = 3 },
                            new OrderItem { ProductId = 1, Quantity = 10 }
                        
                        }
                    }
                }
            },
            new Customer
            {
                Id = 3,
                Name = "Charlie",
                Orders = new List<Order>() // No orders
            }
        };
        }
    }
}
