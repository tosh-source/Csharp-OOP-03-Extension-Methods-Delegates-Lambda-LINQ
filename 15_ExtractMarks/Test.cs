using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _15_ExtractMarks.Models;
using SharedClassStudents.Models;

namespace _15_ExtractMarks
{
    class Test
    {
        static void Main(string[] args)
        {
            Students[] students =
            {
                new Students { FacultyNumber = "123406", FirstName = "Ivan", LastName = "Dimov", Mark = new List<int>() { 4, 2} },
                new Students { FacultyNumber = "586007", FirstName = "Vera", LastName = "Aleksieva", Mark = new List<int>() { 2, 5} },
                new Students { FacultyNumber = "453509", FirstName = "Khan", LastName = "Asparuh", Mark = new List<int>() { 3, 3} },
                new Students { FacultyNumber = "222206", FirstName = "Dragan", LastName = "Tsankov", Mark = new List<int>() { 3, 2} },
                new Students { FacultyNumber = "435314", FirstName = "Jon", LastName = "Brown", Mark = new List<int>() { 6, 2} },
                new Students { FacultyNumber = "424306", FirstName = "Ivan", LastName = "Stefanov", Mark = new List<int>() { 2, 5, 5} },
                new Students { FacultyNumber = "785406", FirstName = "Vera", LastName = "Georgieva", Mark = new List<int>() { 3} }
            };

            var studentsEnrolledYear = "2006";
            var takeMarksEnrolledIn2006 = QueryOperations.ExtractMarks(studentsEnrolledYear, students);

            Console.WriteLine("Extract all `Marks` of the students that enrolled in 2006:");
            Console.WriteLine(string.Join("\n", takeMarksEnrolledIn2006));
        }
    }
}
