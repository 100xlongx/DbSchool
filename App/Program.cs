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

            Console.WriteLine("Inserting a new student");
            // db.Add(new Student { Id = 1 });
            // db.SaveChanges();

            // Read
            Console.WriteLine("Querying for a student");
    }
    }
}
