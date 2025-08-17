## Multi-Level Join with Grouping and Conditional Aggregation

### Problem

You have lists of **Orders**, **Products**, and **Categories**:

- Each **Order** contains a `ProductId` and `Quantity`.  
- Each **Product** has a `CategoryId`.  
- Each **Category** has a `Name`.  

Write a LINQ query to get the **total quantity sold per category**, **but only include categories where the total quantity sold > 100**.


### Models

```csharp
public class Order
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```
