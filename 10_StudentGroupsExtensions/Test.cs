using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClassStudents.Models;
using _10_StudentGroupsExtensions.Models;

namespace _10_StudentGroupsExtensions
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            students.Add(new Students { FirstName = "Ivan", LastName = "Dimov", Age = 20, GroupNumber = 2 });
            students.Add(new Students { FirstName = "Dragan", LastName = "Tsankov", Age = 20, GroupNumber = 1 });
            students.Add(new Students { FirstName = "Khan", LastName = "Asparuh", Age = 33, GroupNumber = 2 });
            students.Add(new Students { FirstName = "Jon", LastName = "Brown", Age = 20, GroupNumber = 4 });
            students.Add(new Students { FirstName = "Vera", LastName = "Georgieva", Age = 45, GroupNumber = 1 });
            students.Add(new Students { FirstName = "Vera", LastName = "Aleksieva", Age = 17, GroupNumber = 3 });
            students.Add(new Students { FirstName = "Ivan", LastName = "Stefanov", Age = 33, GroupNumber = 2 });

            var selectGroup2Only = QueryOperations.TakeGroupTwo(students);

            Console.WriteLine(string.Join("\n", selectGroup2Only));
        }
    }
}
