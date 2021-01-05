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
            Console.WriteLine(firstType.CollectionSum());

            IEnumerable<string> secondType = new[] { "2", "1", "2" };
            //Console.WriteLine(secondType.CollectionSum());     //Should throw an exception! Only ValueTypes can be calculated!
            //Console.WriteLine(secondType.CollectionProduct());

            Console.WriteLine(firstType.CollectionProduct());
            Console.WriteLine(firstType.CollectionMin());
            Console.WriteLine(firstType.CollectionMax());
            Console.WriteLine(firstType.CollectionAverage());

        }
    }
}
