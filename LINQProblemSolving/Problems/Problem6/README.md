## Conditional Group Aggregation

### 📋 Problem

You have a list of sales data.  
Group the data by **Region**, and for each region, calculate:

- Total sales  
- Average sales  
- Number of **high-value sales** (sales over 1000)


### 🏗️ Model

```csharp
public class Sale
{
    public string Region { get; set; }
    public decimal Amount { get; set; }
}
```
