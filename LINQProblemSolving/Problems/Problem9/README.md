## Multi-Level Nested Join with Filtering

### Problem

You have a list of **Customers**, each with a list of **Orders**, and each order contains multiple **OrderItems** referencing a **Product**.  

Return a list of customers and their **total spend on "Electronics" products only**, sorted **descending by total spend**.


### Models

```csharp
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public List<OrderItem> Items { get; set; }
}

public class OrderItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}
```
