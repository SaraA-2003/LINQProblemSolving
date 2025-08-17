## Time-Series Aggregation by Month and Category

### Problem

Given a list of **Transactions** with `Date`, `Amount`, and `Category`,  
group the transactions by **month** and **category**, and return the **total amount per group**.


### Model

```csharp
public class Transaction
{
    public DateTime Date { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }
}
```
