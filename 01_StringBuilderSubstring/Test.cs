using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Test
    {
        static void Main(string[] args)
        {
            //Test extended method Substring form .
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Some test text here.");

            Console.WriteLine(stringBuilder.Substring(5, 9));
        }
    }
}
