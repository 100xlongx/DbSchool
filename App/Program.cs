using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SchoolContext();

            //1
            Console.WriteLine("Querying for a student");
            foreach(var student in db.Students){
                Console.WriteLine($"{student.Id} : {student.LastName}, {student.FirstName}");
            }


            //2
            Console.WriteLine("Querying for Rick and his grades");
            Student student1 = db.Students.Where(Student => Student.FirstName == "Rick").FirstOrDefault();

            Console.WriteLine($"{student1.FirstName} : {student1.LastName}");

            db.Grades.Where(grade => grade.StudentId == student1.Id).ToList().ForEach((Grade grade) => 
            Console.WriteLine($"{grade.CourseName} : {grade.GradeP}")
            );

            //3
            Console.WriteLine("Querying for Rick and his grades");
            var grades3 = db.Grades.Where(grade => grade.StudentId == student1.Id).ToList().Average(grade => grade.GradeP);
            Console.WriteLine($"Rick's average grade is {grades3}");

            //4
            Console.WriteLine("Querying for student with highest average grade");

            var grades4 = from grades in db.Grades
            group grades by grades.StudentId into studentGroup
            select new 
            {
                Student = studentGroup.Key,
                Average = studentGroup.Average(x => x.GradeP)
            };

            var maxAverage = grades4.ToList().Max(x => x.Average);

            Console.WriteLine($"The max average is {maxAverage}");
            
            //5
            var grades5 = from grades in db.Grades
            group grades by grades.StudentId into studentGroup
            select new 
            {
                Student = studentGroup.Key,
                Count = studentGroup.Count(),
            };

            var maxCount = grades5.ToList().Max(s => s.Count);

            // Student student5 = db.Students.Where(Student => Student.Id == ).FirstOrDefault();

            Console.WriteLine($"The max course count is {maxCount}");

            //6










    }
    }
}
