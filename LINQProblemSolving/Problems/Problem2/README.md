## LINQ Example: Grouping Orders by Customer

Consider the following list of orders:
```csharp
var orders = new List<Order>
{
    new Order { OrderId = 1, CustomerName = "Ali", Amount = 250 },
    new Order { OrderId = 2, CustomerName = "Ahmad", Amount = 150 },
    new Order { OrderId = 3, CustomerName = "Ali", Amount = 300 }
   new Order { OrderId = 3, CustomerName = "Haya", Amount = 300 }

};

### Task
Write a LINQ query to group orders by CustomerName and calculate the total amount spent by each customer.
