## Join & GroupBy & Aggregation

###  Problem

Join **Orders** with **Products** to generate a report of **total quantity sold per product category**.


###  Models

```csharp
public class Order
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Category { get; set; }
}
```
