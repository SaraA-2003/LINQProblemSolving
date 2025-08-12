using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem7
{
    public class Order
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public static List<Order> GetAllOrders()
        {
            return new List<Order>
        {
            new Order { ProductId = 1, Quantity = 5 },
            new Order { ProductId = 2, Quantity = 10 },
            new Order { ProductId = 3, Quantity = 2 },
            new Order { ProductId = 1, Quantity = 1 }
        };
        }
    }

}
