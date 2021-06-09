using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClassStudents.Models;

namespace _16_Groups.Models
{
    class QueryOperations
    {
        public static IEnumerable GroupDepartment(Group[] groupOfDepartments, string groupCriteria = "Mathematics", params Students[] students)
        {
            var groupDepartment =
                from currentStudent in students
                join currentGroup in groupOfDepartments
                on currentStudent.GroupNumber equals currentGroup.GroupNumber
                where currentGroup.DepartmentName == groupCriteria
                select new
                {
                    Student = currentStudent.FirstName + " " + currentStudent.LastName,
                    Department = currentGroup.DepartmentName
                };

            return groupDepartment;
        }
    }
}
