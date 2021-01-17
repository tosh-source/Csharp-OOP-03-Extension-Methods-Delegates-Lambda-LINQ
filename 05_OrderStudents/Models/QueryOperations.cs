using System.Collections.Generic;
using System.Linq;
using SharedClassStudents.Models;

namespace _05_OrderStudents.Models
{
    public static class QueryOperations
    {
        public static IEnumerable<string> OrderStudentsByLambda(params Students[] students)
        {
            var result = students.OrderByDescending(student => student.FirstName)
                                 .ThenByDescending(student => student.LastName)
                                 .Select(student => student.FirstName + " " + student.LastName);

            return result;
        }

        public static IEnumerable<string> OrderStudentsByLINQ(params Students[] students)
        {
            var result =
                from student in students
                orderby student.FirstName descending, student.LastName descending  //There is no special keyword for .ThenBy() . But how to use? Example: "orderby firstQuery, secondQuery" <- secondQuery is actually .ThenBy()
                select student.FirstName + " " + student.LastName;

            return result;
        }
    }
}
