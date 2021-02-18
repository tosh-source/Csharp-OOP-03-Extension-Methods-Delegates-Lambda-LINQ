using SharedClassStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _19_GroupedByGroupNumberЕxtensions.Models
{
    class QueryOperations
    {
        public static IEnumerable<IGrouping<int, Students>> GroupStudents(params Students[] students)
        {
            var result = students.OrderBy(student => student.GroupNumber)
                                 .GroupBy(student => student.GroupNumber);

            return result;
        }
    }
}
