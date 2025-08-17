# LINQ Example: Group Employees by Salary

### Given Data

```csharp
var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Nidal", Salary = 3000 },
    new Employee { Id = 2, Name = "Sara", Salary = 4000 },
    new Employee { Id = 3, Name = "Areen", Salary = 3500 },
    new Employee { Id = 4, Name = "Abdullah", Salary = 3000 },
    new Employee { Id = 5, Name = "Ehab", Salary = 1000 }, // :p 
    new Employee { Id = 6, Name = "Afaf", Salary = 3500 },
    new Employee { Id = 7, Name = "Worood", Salary = 3500 }
};
````
### Task

- Group employees by Salary.

- Within each group, order employees by Name alphabetically.

- Select only groups where the number of employees in that group is greater than 2.

- Return result as a list of objects with:

  - Salary

  - EmployeeNames (comma-separated string of names in that group).

### Expected Output
```csharp
[
  { "Salary": 3500, "EmployeeNames": "Afaf, Areen, Worood" }
]

```
