using System.Collections.Generic;
using System.Linq;
using SharedClassStudents.Models;

namespace _03_FirstBeforeLast.Models
{
    public class QueryOperators : Students
    {
        public static IEnumerable<string> OrderFirstBeforeLast(params Students[] students)  //or write as extension method
        {
            var orderFirstBeforeLast =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student.FirstName + " " + student.LastName;

            return orderFirstBeforeLast;
        }
    }
}
