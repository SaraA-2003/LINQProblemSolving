using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problem3
{
    internal class Problem3
    {
        public static void Run()
        {
            var employees = new List<Employee>
                {
                    new Employee { Id = 1, Name = "Nidal", Salary = 3000 },
                    new Employee { Id = 2, Name = "Sara", Salary = 4000 },
                    new Employee { Id = 3, Name = "Areen", Salary = 3500 },
                    new Employee { Id = 3, Name = "Abdullah", Salary = 3000 },
                    new Employee { Id = 3, Name = "Ehab", Salary = 1000 }, 
                    new Employee { Id = 3, Name = "Afaf", Salary = 3500 },
                    new Employee { Id = 3, Name = "Worood", Salary = 3500 }
                };

            var GSalary = employees.GroupBy(e => e.Salary)
                .Where(e=> e.Count() >2)
                .OrderBy(s => s.Key)
                .Select(e => new {Salary = e.Key , Name = e.Select(n => n.Name)
                .OrderBy(n => n)
                .Aggregate((a, b) => a + ", " + b) });

            Console.WriteLine("Group by Salary");
            foreach(var employee in GSalary)
            {
                Console.WriteLine($"[\n{{Salary = {employee.Salary},EmployeeNames = \" {employee.Name}\"}}\n]\n");
            }

            

        }
    }
}
