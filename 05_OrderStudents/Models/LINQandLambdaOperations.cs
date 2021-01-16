using System.Collections.Generic;
using System.Linq;
using SharedClassStudents.Models;

namespace _05_OrderStudents.Models
{
    public static class LINQandLambdaOperations
    {
        public static IEnumerable<string> OrderStudentsByLambda(params Students[] students)
        {
            var result = students.OrderByDescending(student => student.FirstName)
                                 .ThenByDescending(student => student.LastName)
                                 .Select(student => student.FirstName + " " + student.LastName);

            return result;
        }
    }
}
