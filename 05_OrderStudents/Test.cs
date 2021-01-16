using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClassStudents.Models;

namespace _05_OrderStudents.Models
{
    class Test
    {
        static void Main(string[] args)
        {
            Students[] students =
            {
                new Students { FirstName = "Jon", LastName = "Brown", Age = 23 },
                new Students { FirstName = "Ivan", LastName = "Stefanov", Age = 19 },
                new Students { FirstName = "Vera", LastName = "Georgieva", Age =  45 },
                new Students { FirstName = "Vera", LastName = "Aleksieva", Age = 17 }  
            };

            var orderByLambda = LINQandLambdaOperations.OrderStudentsByLambda(students);  //NOTE: In descending order, "Vera Aleksieva" should be AFTER "Vera Georgieva"!

            Console.WriteLine("Show students in descending order (by Lambda):" + "\n" 
                + string.Join("\n", orderByLambda));
        }
    }
}
