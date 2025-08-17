# Nested Projection with `SelectMany`

### Problem

You have a list of `Customer` objects, and each customer has a list of `Orders`.  
Write a LINQ query to get a **flattened list of all orders**, including:

- Customer name  
- Order total  


### Models

```csharp
public class Customer
{
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public decimal Total { get; set; }
}
