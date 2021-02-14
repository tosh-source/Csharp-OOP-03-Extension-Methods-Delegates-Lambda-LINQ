using System;
using System.Linq;

namespace _17_LongestString.Models
{
    class QueryOperations
    {
        public static string ReturnLongestString(params string[] stringArray)
        {
            var result =
                (from currentString in stringArray
                 orderby currentString.Length
                 select currentString).Last();

            return result;
        }
    }
}
