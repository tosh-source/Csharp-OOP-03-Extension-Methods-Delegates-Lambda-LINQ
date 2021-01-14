using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClassStudents.Models;

namespace _04_AgeRange.Models
{
    class Test
    {
        static void Main(string[] args)
        {
            Students[] students =
            {
                new Students { FirstName = "Jon", LastName = "Brown", Age = 23},
                new Students { FirstName = "Ivan", LastName = "Stefanov", Age = 19},
                new Students { FirstName = "Vera", LastName = "Georgieva", Age =  45}
            };

            var result = QueryOperators.AgeRange(students);

            Console.WriteLine("Only show students in range from 18 to 24: " + "\n"
                + string.Join("\n", result));

            Console.WriteLine("\n" + "Only show students in range from 18 to 24: " + "\n"
                + string.Join("\n", students.AgeRangeExtMethod()));
        }
    }
}
