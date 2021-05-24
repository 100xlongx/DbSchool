﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SchoolContext();
            Console.WriteLine("Querying for a student");
            foreach(var student in db.Students){
                Console.WriteLine($"{student.Id} : {student.LastName}, {student.FirstName}");
            }
    }
    }
}
