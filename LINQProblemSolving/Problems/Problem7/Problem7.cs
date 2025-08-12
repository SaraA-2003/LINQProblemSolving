using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem7
{
    internal class Problem7
    {
        public static void Run()
        {
            //Join Orders with Products to get a report of total quantity sold per product category.

            var result = (Product.GetAllProducts().Join(Order.GetAllOrders(),
                                                   p => p.Id, o => o.ProductId,
                                                   (product, order) => new
                                                   {
                                                       Category = product.Category,
                                                       PQuantity = order.Quantity

                                                   }).GroupBy(x => x.Category).Select(x => new
                                                   {
                                                       Category = x.Key,
                                                       TotalQuantity = x.Sum(q => q.PQuantity)

                                                   })).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);

            }


            Console.WriteLine("\n---------------SQL Like---------------------------\n");

            var result2 = (from product in Product.GetAllProducts()
                           join order in Order.GetAllOrders()
                           on product.Id equals order.ProductId
                           group order by product.Category into CGroup
                           select new
                           {
                               Category = CGroup.Key,
                               TotalQuantity = CGroup.Sum(q => q.Quantity)
                           }).ToList();



            foreach (var item in result)
            {
                Console.WriteLine(item);

            }

        }                
    }
}
