using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FirstBeforeLast.Models
{
    public class Test
    {
        static void Main(string[] args)
        {
            Students[] students = new Students[3];
            students[0] = new Students { FirstName = "Vera", LastName = "Georgieva" };
            students[1] = new Students { FirstName = "Ivan", LastName = "Stefanov" };
            students[2] = new Students { FirstName = "Jon", LastName = "Brown" };

            var result = QueryOperators.OrderFirstBeforeLast(students);

            Console.WriteLine("Order by first name:" + "\n" + string.Join("\n", result));  //Only "Ivan Stefanov" should be printed.
        }
    }
}
