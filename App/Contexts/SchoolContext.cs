using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App {
    public class SchoolContext : DbContext
    {
        // public DbSet<Customer> Customers { get; set; }
        // public DbSet<Invoice> Invoices { get; set; }
        // public DbSet<InvoiceItem> InvoiceItems { get; set; }

        public DbSet<Grade> Grades {get; set;}
        public DbSet<Student> Students {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SchoolDB.db;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(new Student[] {
            new Student { Id = 1, FirstName = "Pickle", LastName = "Rick" },
            new Student { Id = 2, FirstName = "Rick", LastName = "Sanchez" },
            new Student { Id = 3, FirstName = "Tom", LastName = "Hanks" },
            });

            modelBuilder.Entity<Grade>().HasData(new Grade[] { 
            new Grade { Id = 1, StudentId = 1, GradeP = 0.20F },
            new Grade { Id = 2, StudentId = 2, GradeP = 0.90F },
            new Grade { Id = 3, StudentId = 3, GradeP = 0.25F },
            });

            base.OnModelCreating(modelBuilder);
        

        }
    }
}
