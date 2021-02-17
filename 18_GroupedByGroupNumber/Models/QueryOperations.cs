using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SharedClassStudents.Models;

namespace _18_GroupedByGroupNumber.Models
{
    static class QueryOperations
    {
        public static IEnumerable<IGrouping<int, Students>> GroupStudents(params Students[] students)
        {
            var result =
                from student in students
                orderby student.GroupNumber
                group student by student.GroupNumber;

            return result;
        }
    }
}
