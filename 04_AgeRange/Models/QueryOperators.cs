using System.Collections.Generic;
using System.Linq;
using SharedClassStudents.Models;

namespace _04_AgeRange.Models
{
    public static class QueryOperators
    {
        public static IEnumerable<string> AgeRange(params Students[] students)
        {
            var ageRange =
                from student in students
                where student.Age > 18 && student.Age < 24
                select student.FirstName + " " + student.LastName;

            return ageRange;
        }
    }
}
