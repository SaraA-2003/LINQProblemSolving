using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSolving.Problem4
{
    internal class Problem4
    {
        public static void Run()
        {
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


            var result = students.Join(
                grades,
                s => s.Id,
                g => g.StudentId,
                (s, g) => new
                {
                    StudentName = s.Name,
                    SScore = g.Score
                });

            Console.WriteLine("Lambda expression");
            foreach (var student in result)
            {
                Console.WriteLine($"{student.StudentName} - {student.SScore}");
            }


            var result2 = from student in students
                          join grade in grades on student.Id equals grade.StudentId
                          select new { StudentName = student.Name, StudentScore = grade.Score };

            Console.WriteLine("\nSQL like");
            foreach(var student in result2)
            {
                Console.WriteLine($"{student.StudentName} - {student.StudentScore}");

            }


        }
    }
}
