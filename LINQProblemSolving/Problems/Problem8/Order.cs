using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem8
{
    public class Order
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public static List<Order> GetAllOrders()
        {
            return new List<Order>
        {
            new () { ProductId = 1, Quantity = 50 },
            new () { ProductId = 2, Quantity = 200 },
            new () { ProductId = 4, Quantity = 50 },
            new () { ProductId = 4, Quantity = 1000 },
            new () { ProductId = 1, Quantity = 60 }, 
            
            };
        }
    }

}
