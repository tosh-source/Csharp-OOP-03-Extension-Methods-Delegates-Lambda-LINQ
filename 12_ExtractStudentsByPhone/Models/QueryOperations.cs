using System.Collections.Generic;
using System.Linq;
using SharedClassStudents.Models;

namespace _12_ExtractStudentsByPhone.Models
{
    class QueryOperations
    {
        public static IEnumerable<string> GroupByTelFromSofia(params Students[] students)
        {
            var result =
                from student in students
                where student.Tel.Contains("-02-") == true
                select student.FirstName + " " + student.LastName;

            return result;
        }
    }
}
