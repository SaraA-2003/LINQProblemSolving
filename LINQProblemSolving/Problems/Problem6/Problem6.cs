using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem6
{
    internal class Problem6
    {
        public static void Run()
        {
            //Group Sales data by region, and for each region,
            //calculate the total sales, average sales,
            //and number of high-value sales (sales over 1000).

            var result = Sale.GetAllSales().GroupBy(r => r.Region)
                                            .Select(x => new
                                            {
                                                RegionId = x.Key,
                                                TotalSales = x.Sum(a => a.Amount),
                                                AverageSales = x.Average(a => a.Amount),
                                                HighValueSales = x.Where(a => a.Amount > 1000).Count()

                                            });

            foreach (var item in result)
            {
                Console.WriteLine("Region: {0}\n\tTotal Sales: {1}\n\tAverage Sales: " +
                    "{2}\n\tNumber of High Value Sales (over 1000): {3}", item.RegionId,item.TotalSales, item.AverageSales, item.HighValueSales);
                Console.WriteLine();
            }

            Console.WriteLine("\n-----------------Query Method-------------------------\n");

            var result2 = from sale in Sale.GetAllSales()
                          group sale by sale.Region into Group
                          select new 
                            {
                              RegionId = Group.Key,
                              TotalSales = Group.Sum(a => a.Amount),
                              AverageSales = Group.Average(a => a.Amount),
                              HighValueSales = Group.Count(a => a.Amount > 1000)

                          };

            foreach (var item in result2)
            {
                Console.WriteLine("Region: {0}\n\tTotal Sales: {1}\n\tAverage Sales: " +
                    "{2}\n\tNumber of High Value Sales (over 1000): {3}", item.RegionId, item.TotalSales, item.AverageSales, item.HighValueSales);
                Console.WriteLine();
            }
        }
    }
}
