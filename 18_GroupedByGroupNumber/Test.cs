using System;
using System.Collections.Generic;
using System.Linq;
using _18_GroupedByGroupNumber.Models;
using SharedClassStudents.Models;

namespace _18_GroupedByGroupNumber
{
    class Test
    {
        static void Main(string[] args)
        {
            Students[] students =
            {
                new Students { FirstName = "Ivan", LastName = "Dimov", Email = "ivan_dimov@gmail.com", GroupNumber = 2 },
                new Students { FirstName = "Vera", LastName = "Georgieva", Email = "vg@abv.bg", GroupNumber = 1 },
                new Students { FirstName = "Dragan", LastName = "Tsankov", Email = "mr_dragan@outlook.com", GroupNumber = 5 },
                new Students { FirstName = "Khan", LastName = "Asparuh", Email = "asparuh@gmail.com", GroupNumber = 6 },
                new Students { FirstName = "Vera", LastName = "Aleksieva", Email = "vera@abv.bg", GroupNumber = 3 },
                new Students { FirstName = "Jon", LastName = "Brown", Email = "jbrown@hotmail.com", GroupNumber = 4 },
                new Students { FirstName = "Ivan", LastName = "Stefanov", Email = "ivan@abv.bg", GroupNumber = 7 }
            };

            var studentGroups = QueryOperations.GroupStudents(students);

            foreach (var currentGroup in studentGroups)
            {
                Console.WriteLine(currentGroup.Key);

                foreach (var currentStudent in currentGroup)
                {
                    Console.WriteLine(currentStudent.FirstName + " " + currentStudent.LastName);
                }
            }
        }
    }
}
