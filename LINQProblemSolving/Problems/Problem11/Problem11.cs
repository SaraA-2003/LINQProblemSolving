using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem11
{
    internal class Problem11
    {
        public static void Run()
        {
            //Given a list of Transactions with Date, Amount, and Category ,
            //group by month and category, and return total per group.

            var result = Transaction.GetAllTransactions()
                .GroupBy(x => new { x.Date.Date.Month, x.Category })
                .Select(x => new
                {
                    Month = x.Key.Month,
                    Category = x.Key.Category,
                    TotalPerGroup = x.Sum(t => t.Amount)

                }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("\n-------------Query Method--------------------");
            var result2 = from transaction in Transaction.GetAllTransactions()
                          group transaction by new { transaction.Date.Date.Month, transaction.Category } into Group
                          select new
                          {
                              Month = Group.Key.Month,
                              Category = Group.Key.Category,
                              TotalPerGroup = Group.Sum(t => t.Amount)


                          };

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }


        }
    }
}
