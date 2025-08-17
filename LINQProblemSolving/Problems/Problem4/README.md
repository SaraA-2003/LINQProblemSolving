# Join Students with Grades

### Given Data

```csharp
var students = new List<Student>
{
    new Student { Id = 1, Name = "Ali" },
    new Student { Id = 2, Name = "Sara" }
};

var grades = new List<Grade>
{
    new Grade { StudentId = 1, Score = 85 },
    new Grade { StudentId = 2, Score = 92 }
};
```
### Task

Write a LINQ join query to return each student's Name along with their Score.

### Expected Output

```csharp
Ali: 85
Sara: 92
```
