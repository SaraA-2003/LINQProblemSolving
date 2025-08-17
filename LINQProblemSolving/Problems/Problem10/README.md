## Dynamic Grouping with Sub-Aggregates

### Problem

Group **sales data by Region**. For each region, generate:

- Total Sales  
- Number of distinct customers  
- Max single transaction  
- Sales breakdown by high vs low (above 1000 vs ≤ 1000)


### Model

```csharp
public class Sale
{
    public string Region { get; set; }
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
}
```
