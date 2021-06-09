using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClassStudents.Models;
using _16_Groups.Models;

namespace _16_Groups
{
    class Tests
    {
        static void Main(string[] args)
        {
            var departmentGroups = new Group[]
            {
               new Group { DepartmentName = "Mathematics", GroupNumber = 1 },
               new Group { DepartmentName = "Biology", GroupNumber = 2 },
               new Group { DepartmentName = "Anatomy", GroupNumber = 3 },
               new Group { DepartmentName = "English", GroupNumber = 4 }
            };
            var groupCriteria = "Mathematics";
            var students = new[]
            {
                new Students { FirstName = "Ivan", LastName = "Dimov", Tel = "+359-056-235486", Email = "ivan_dimov@gmail.com", GroupNumber = 2 },
                new Students { FirstName = "Dragan", LastName = "Tsankov", Tel = "+359-02-487956", Email = "mr_dragan@outlook.com", GroupNumber = 1 },
                new Students { FirstName = "Vera", LastName = "Georgieva", Tel = "+359-068-203154", Email = "vg@abv.bg", GroupNumber = 1 },
                new Students { FirstName = "Vera", LastName = "Aleksieva", Tel = "+359-02-458565", Email = "vera@abv.bg", GroupNumber = 3 },
                new Students { FirstName = "Khan", LastName = "Asparuh", Tel = "+359-056-666589", Email = "asparuh@gmail.com", GroupNumber = 2 },
                new Students { FirstName = "Jon", LastName = "Brown", Tel = "+359-02-444889", Email = "jbrown@hotmail.com", GroupNumber = 4 },
                new Students { FirstName = "Ivan", LastName = "Stefanov", Tel = "+359-02-444111", Email = "ivan@abv.bg", GroupNumber = 2 },
                new Students { FirstName = "Greg", LastName = "Price", Tel =  "+359-02-087111", Email = "greg@gmail.com", GroupNumber = 1 }
            };

            var mathDepartment = QueryOperations.GroupDepartment(departmentGroups, groupCriteria, students);

            foreach (var student in mathDepartment)
            {
                Console.WriteLine(string.Join("\n", student));
            }
        }
    }
}
