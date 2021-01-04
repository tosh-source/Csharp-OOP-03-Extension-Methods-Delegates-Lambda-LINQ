using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Test
    {
        static void Main(string[] args)
        {
            IEnumerable<int> firstType = new [] { 2, 1, 2 };
            Console.WriteLine(firstType.SumOfCollection());

            IEnumerable<string> secondType = new[] { "2", "1", "2" }; 
            //Console.WriteLine(secondType.SumOfCollection());  //should throw exception! Only ValueTypes can be calculated!
        }
    }
}
