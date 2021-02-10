using System;
using SharedClassStudents.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ExtractStudentsByMarks.Models
{
    class QueryOperations
    {
        public static IEnumerable<string> GetStudentsByMarks(params Students[] students)
        {
            var result =
                from student in students
                where student.Mark.Contains(6)
                select student.FirstName + " " + student.LastName;

            return result;
        }
    }
}
