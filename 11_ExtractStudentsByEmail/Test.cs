using System;
using SharedClassStudents.Models;
using _11_ExtractStudentsByEmail.Models;


namespace _11_ExtractStudentsByEmail
{
    class Test
    {
        static void Main(string[] args)
        {
            Students[] students = new[]
            {
                new Students { FirstName = "Ivan", LastName = "Dimov", Email = "ivan_dimov@gmail.com", GroupNumber = 2 },
                new Students { FirstName = "Vera", LastName = "Georgieva", Email = "vg@abv.bg", GroupNumber = 1 },
                new Students { FirstName = "Dragan", LastName = "Tsankov", Email = "mr_dragan@outlook.com", GroupNumber = 1 },
                new Students { FirstName = "Khan", LastName = "Asparuh", Email = "asparuh@gmail.com", GroupNumber = 2 },
                new Students { FirstName = "Vera", LastName = "Aleksieva", Email = "vera@abv.bg", GroupNumber = 3 },
                new Students { FirstName = "Jon", LastName = "Brown", Email = "jbrown@hotmail.com", GroupNumber = 4 },
                new Students { FirstName = "Ivan", LastName = "Stefanov", Email = "ivan@abv.bg", GroupNumber = 2 }
            };

            var selectByEmail = QueryOperations.ExtractByEmail(students);

            Console.WriteLine(string.Join("\n", selectByEmail));
        }
    }
}
