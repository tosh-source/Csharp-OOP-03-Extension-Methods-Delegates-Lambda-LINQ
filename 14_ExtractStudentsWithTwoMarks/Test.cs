using System;
using SharedClassStudents.Models;
using System.Collections.Generic;
using System.Linq;
using _14_ExtractStudentsWithTwoMarks.Models;

namespace _14_ExtractStudentsWithTwoMarks
{
    class Test
    {
        static void Main(string[] args)
        {
            Students[] students =
                {
                    new Students { FirstName = "Ivan", LastName = "Dimov", Mark = new List<int>() { 4, 2} },
                    new Students { FirstName = "Dragan", LastName = "Tsankov", Mark = new List<int>() { 3, 2} },
                    new Students { FirstName = "Vera", LastName = "Georgieva", Mark = new List<int>() { 3} },
                    new Students { FirstName = "Vera", LastName = "Aleksieva", Mark = new List<int>() { 2, 5} },
                    new Students { FirstName = "Khan", LastName = "Asparuh", Mark = new List<int>() { 3, 3} },
                    new Students { FirstName = "Jon", LastName = "Brown", Mark = new List<int>() { 6, 2} },
                    new Students { FirstName = "Ivan", LastName = "Stefanov", Mark = new List<int>() { 2, 5, 5} }
                };

            //Add more marks.
            //Ivan's marks.
            students[0].Mark.Add(2);
            students[0].Mark.Add(3);
            students[0].Mark.Add(6);
            //Dragan's marks.
            students[1].Mark.Add(6);
            //Vera's marks.
            students[2].Mark.Add(5);

            var takeStudentsWithBadMarks = QueryOperations.GetStudentsByMarks(students);
            Console.WriteLine(string.Join("\n", takeStudentsWithBadMarks));
        }
    }
}
