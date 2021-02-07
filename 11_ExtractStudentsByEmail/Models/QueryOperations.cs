using System;
using SharedClassStudents.Models;
using System.Collections.Generic;
using System.Linq;

namespace _11_ExtractStudentsByEmail.Models
{
    class QueryOperations
    {
        public static IEnumerable<string> ExtractByEmail(params Students[] students)
        {
            var result =
                from student in students
                where student.Email.Contains("abv.bg") == true
                select student.FirstName + " " + student.LastName;

            return result;
        }
    }
}
