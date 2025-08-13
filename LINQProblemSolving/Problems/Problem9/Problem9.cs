namespace LINQProblemSolving.Problems.Problem9
{
    internal class Problem9
    {

        public static void Run()
        {
            var result = Customer.GetAllCustomers().Select(x => new
            {
                CustomerName = x.Name,
                TotalSpentE = x.Orders.SelectMany(o => o.Items) //if it didnot purchase electronics it will be zero
                    .Join(Product.GetAllProducts(),
                     i => i.ProductId,
                     p => p.Id,
                     (item, product) => new
                     {
                        item,
                        product

                     }).Where(x => x.product.Category == "Electronics")
                     .Sum(x => x.item.Quantity * x.product.Price)

            }).Where(x=> x.TotalSpentE >0).OrderByDescending(x=> x.TotalSpentE).ToList();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n----------Query Method-----------\n");

            var result2 = (from customer in Customer.GetAllCustomers()
                          let TotalSpentE =
                          (
                          from o in customer.Orders
                          from c in o.Items
                          join p in Product.GetAllProducts()
                          on c.ProductId equals p.Id
                          where p.Category == "Electronics"
                          //were here is only for the select: if someone that doesnot bought electronics the 
                          //total spend will be zero
                          select c.Quantity * p.Price).Sum()
                          where TotalSpentE > 0
                          orderby TotalSpentE descending
                          select new
                          {
                              CustomerName = customer.Name,
                              TotalSpend = TotalSpentE
                          }).ToList();

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }




        }
    }
}
