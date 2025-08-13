using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem10
{
    public class Sale
    {
        public string Region { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }

        public static List<Sale> GetAllSales()
        {
            return new List<Sale>
        {
            new Sale { Region = "North", CustomerId = 1, Amount = 1500.50m },
            new Sale { Region = "North", CustomerId = 2, Amount = 200.00m },
            new Sale { Region = "South", CustomerId = 3, Amount = 5000.75m },
            new Sale { Region = "East", CustomerId = 4, Amount = 120.00m },
            new Sale { Region = "South", CustomerId = 1, Amount = 2000.25m },
            new Sale { Region = "East", CustomerId = 2, Amount = 180.00m },
            new Sale { Region = "West", CustomerId = 3, Amount = 200.50m }
        };
        }
    }
}
