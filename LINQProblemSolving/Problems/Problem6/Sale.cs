using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem6
{
    public class Sale
    {
        public string Region { get; set; }
        public decimal Amount { get; set; }

        public static List<Sale> GetAllSales()
        {
            return new List<Sale>
    {
        // North Region
        new Sale { Region = "North", Amount = 500m },
        new Sale { Region = "North", Amount = 1200m },
        new Sale { Region = "North", Amount = 2500m },
        new Sale { Region = "North", Amount = 800m },

        // South Region
        new Sale { Region = "South", Amount = 1500m },
        new Sale { Region = "South", Amount = 300m },
        new Sale { Region = "South", Amount = 2200m },
        new Sale { Region = "South", Amount = 750m },

        // East Region
        new Sale { Region = "East", Amount = 950m },
        new Sale { Region = "East", Amount = 1100m },
        new Sale { Region = "East", Amount = 2000m },
        new Sale { Region = "East", Amount = 1750m },

        // West Region
        new Sale { Region = "West", Amount = 1300m },
        new Sale { Region = "West", Amount = 900m },
        new Sale { Region = "West", Amount = 2000m },
        new Sale { Region = "West", Amount = 600m }
    };
        }
    }

}
