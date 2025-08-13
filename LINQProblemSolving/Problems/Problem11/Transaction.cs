using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem11
{
    using System;
    using System.Collections.Generic;

    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public static List<Transaction> GetAllTransactions()
        {
            return new List<Transaction>
        {
            new Transaction { Date = new DateTime(2025, 1, 5), Category = "Food", Amount = 45.50m },
            new Transaction { Date = new DateTime(2025, 1, 12), Category = "Food", Amount = 15.00m },

            new Transaction { Date = new DateTime(2025, 1, 12), Category = "Transport", Amount = 15.00m },
            new Transaction { Date = new DateTime(2025, 1, 18), Category = "Entertainment", Amount = 120.00m },

            new Transaction { Date = new DateTime(2025, 2, 2), Category = "Food", Amount = 55.25m },
            new Transaction { Date = new DateTime(2025, 2, 7), Category = "Transport", Amount = 20.00m },
            new Transaction { Date = new DateTime(2025, 2, 25), Category = "Food", Amount = 35.00m },

            new Transaction { Date = new DateTime(2025, 4, 3), Category = "Bills", Amount = 300.00m },
            new Transaction { Date = new DateTime(2025, 3, 15), Category = "Food", Amount = 70.00m },
            new Transaction { Date = new DateTime(2025, 3, 22), Category = "Entertainment", Amount = 200.00m },

            new Transaction { Date = new DateTime(2025, 4, 5), Category = "Food", Amount = 65.00m },
            new Transaction { Date = new DateTime(2025, 4, 8), Category = "Bills", Amount = 150.00m },
            new Transaction { Date = new DateTime(2025, 4, 20), Category = "Transport", Amount = 18.00m }
        };
        }
    }

}
