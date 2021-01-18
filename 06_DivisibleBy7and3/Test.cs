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
            Console.WriteLine(integers.AllDivisibleNumbsByLambda());  //No divisible numbers! 
            Console.WriteLine(integers.AllDivisibleNumbsByLINQ());    //No divisible numbers!

            integers = new[] { -21, 7, 3, 17, 30, 35, 49, 42 };
            Console.WriteLine(integers.AllDivisibleNumbsByLambda());  //-21, 42
            Console.WriteLine(integers.AllDivisibleNumbsByLINQ());    //-21, 42

            integers = new[] {
                101, 102, 103, 104, 105, 106, 107, 108, 109, 110,
                111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
                121, 122, 123, 124, 125, 126, 127, 128, 129, 130 };

            Console.WriteLine(integers.AllDivisibleNumbsByLambda());  //105, 126
            Console.WriteLine(integers.AllDivisibleNumbsByLINQ());    //105, 126
        }
    }
}
