using System.Collections.Generic;

namespace App
{
    public class Student
    {
        public enum Classification {
            Freshman,
            Sophomore,
            Junior,
            Senior
        }

        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public Classification classification { get; set; }
        public List<Grade> grades { get; set; }

    }
}
