using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClassStudents.Models;


namespace _14_ExtractStudentsWithTwoMarks.Models
{
    class QueryOperations
    {
        public static IEnumerable<string> GetStudentsByMarks(params Students[] students)
        {
            var result = students.Where(student => student.Mark.Contains(6))
                                 .Select(student => student.FirstName + " " + student.LastName);

            return result;
        }
    }
}
