using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DivisibleBy7and3.Models
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(integers.AllDivisibleNumbsByLambda());

            integers = new[] { -21, 7, 3, 17, 30, 35, 49, 42 };
            Console.WriteLine(integers.AllDivisibleNumbsByLambda());
        }
    }
}
