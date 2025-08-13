using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problems.Problem8
{
    internal class Problem8
    {
        public static void Run()
        {
            var result = Category.GetAllCategories().Join(Product.GetAllProducts(),
                                                      c => c.Id,
                                                      p => p.CategoryId,
                                                      (c, p) => new { c, p })
                                                      .Join(Order.GetAllOrders(),
                                                        t => t.p.Id,
                                                        o => o.ProductId,
                                                        (t, o) => new
                                                        {
                                                            CategoryName = t.c.Name,
                                                            Quantity = o.Quantity
                                                        }
                                                        ).GroupBy(a => a.CategoryName)
                                                        .Select(x => new
                                                        {
                                                            TotalQuantity = x.Sum(q=> q.Quantity),
                                                            CategoryName = x.Key
                                                        }).Where(o => o.TotalQuantity > 100).ToList();

            Console.WriteLine("hello");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------Query Method-----------------\n");


            var result2 = (from c in Category.GetAllCategories()
                          join p in Product.GetAllProducts()
                          on c.Id equals p.CategoryId
                          join o in Order.GetAllOrders()
                          on p.Id equals o.ProductId
                          group o by c.Name into Group
                          let TotalQuantinty = Group.Sum(q => q.Quantity)
                          where TotalQuantinty > 100
                          select new
                          {
                              TotalQuantinty = TotalQuantinty,
                              CategoryName = Group.Key
                              
                          }).ToList();


           

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


        }

    }
}
