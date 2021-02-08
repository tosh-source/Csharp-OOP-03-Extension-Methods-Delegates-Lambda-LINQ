using System;
using SharedClassStudents.Models;
using _12_ExtractStudentsByPhone.Models;

namespace _12_ExtractStudentsByPhone
{
    class Test
    {
        static void Main(string[] args)
        {
            Students[] students = new[]
            {
                new Students { FirstName = "Ivan", LastName = "Dimov", Tel = "+359-056-235486", Email = "ivan_dimov@gmail.com", GroupNumber = 2 },
                new Students { FirstName = "Dragan", LastName = "Tsankov", Tel = "+359-02-487956", Email = "mr_dragan@outlook.com", GroupNumber = 1 },
                new Students { FirstName = "Vera", LastName = "Georgieva", Tel = "+359-068-203154", Email = "vg@abv.bg", GroupNumber = 1 },
                new Students { FirstName = "Vera", LastName = "Aleksieva", Tel = "+359-02-458565", Email = "vera@abv.bg", GroupNumber = 3 },
                new Students { FirstName = "Khan", LastName = "Asparuh", Tel = "+359-056-666589", Email = "asparuh@gmail.com", GroupNumber = 2 },
                new Students { FirstName = "Jon", LastName = "Brown", Tel = "+359-02-444889", Email = "jbrown@hotmail.com", GroupNumber = 4 },
                new Students { FirstName = "Ivan", LastName = "Stefanov", Tel = "+359-02-444111", Email = "ivan@abv.bg", GroupNumber = 2 }
            };

            var takeAllContainSophiaTels = QueryOperations.GroupByTelFromSofia(students);

            Console.WriteLine(string.Join("\n", takeAllContainSophiaTels));
        }
    }
}
