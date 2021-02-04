using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClassStudents.Models;

namespace _09_StudentGroups.Models
{
    class QueryOperations
    {
        public static IEnumerable<string> TakeGroupTwo(List<Students> students)
        {
            var result =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student.FirstName + " " + student.LastName;

            return result;
        }
    }
}
