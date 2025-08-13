using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem10
{
    internal class Problem10
    {
        public static void Run()
        {
            /*
             * Group sales data by Region. For each region, generate:
                Total Sales
                Number of distinct customers
                Max single transaction
                Sales breakdown by high vs low (above 1000 vs ≤ 1000)

             */

            var result = Sale.GetAllSales().GroupBy(x => x.Region)
                .Select(x => new
            {
                Region = x.Key,
                TotalSales = x.Sum(t => t.Amount),
                NumOfDistinctC = x.Select(c => c.CustomerId).Distinct().Count(), //x.DistinctBy(c=> c.CustomerId)
                    MaxTransaction = x.Max(x=> x.Amount),
                Breakdown = new 
                { 
                    High = x.Where(x=>x.Amount > 1000).Count(),
                    Low = x.Where(x => x.Amount < 1000).Count(),
                }
                   

                }).ToList();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n---------------Query Method-------------------------\n");
            var result2 = (from s in Sale.GetAllSales()
                          group s by s.Region into Group
                          select new
                          {
                              Region = Group.Key,
                              TotalSales = Group.Sum(t => t.Amount),
                              NumOfDistinctC = Group.DistinctBy(c => c.CustomerId),
                              MaxTransaction = Group.Max(x => x.Amount),
                              Breakdown = Group.Sum(t => t.Amount) > 1000 ? "High" : "Low"



                          }).ToList();


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }




        }
    }
}
