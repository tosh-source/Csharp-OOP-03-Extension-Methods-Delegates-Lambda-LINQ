using System;
using System.Collections.Generic;
using System.Linq;
using SharedClassStudents.Models;

namespace _15_ExtractMarks.Models
{
    class QueryOperations : Students
    {
        public static IEnumerable<string> ExtractMarks(string yearOfEnrolling = "2006", params Students[] students)
        {
            if (yearOfEnrolling.Length != 4)
            {
                throw new ArgumentException("Wrong format! Year example: 2006");
            }

            string enrolledYear = yearOfEnrolling.Remove(0, 2);  //remove first two elements

            var result = students.Where(student => student.FacultyNumber.Contains(enrolledYear))
                                 .Select(student => student.FirstName + " " + student.LastName 
                                         + ": " + string.Join(", ", student.Mark));

            return result;
        }
    }
}
