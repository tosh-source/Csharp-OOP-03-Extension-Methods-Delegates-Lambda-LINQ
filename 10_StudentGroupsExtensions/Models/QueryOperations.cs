using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClassStudents.Models;

namespace _10_StudentGroupsExtensions.Models
{
    class QueryOperations
    {
        public static IEnumerable<string> TakeGroupTwo(List<Students> students)
        {
            var result = students.Where(student => student.GroupNumber == 2)
                                 .OrderBy(student => student.FirstName)
                                 .Select(student => student.FirstName + " " + student.LastName);

            return result;
        }
    }
}
