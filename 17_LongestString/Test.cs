using System;
using _17_LongestString.Models;

namespace _17_LongestString
{
    class Test
    {
        static void Main(string[] args)
        {
            var stringArray = new[]
            {
                "By",
                "By using delegates develop an universal static method to calculate",
                "By using delegates develop an universal static",
                "By using delegates",
                "By using delegates develop an universal static method to calculate the sum.",
                "By using delegates develop an"
            };

            var result = QueryOperations.ReturnLongestString(stringArray);
            Console.WriteLine(result);
        }
    }
}
