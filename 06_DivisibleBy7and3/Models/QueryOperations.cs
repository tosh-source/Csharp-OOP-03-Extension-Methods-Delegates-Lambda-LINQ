using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DivisibleBy7and3.Models
{
    public static class QueryOperations
    {
        public static IEnumerable AllDivisibleNumbsByLambda(this int[] integers)
        {
            var result = integers.ToList().FindAll(ints => (ints % 7 == 0 && ints % 3 == 0));

            if (result.Count == 0)
            {
                return "No divisible numbers to 7 and 3 in array!";
            }

            return string.Join(", ", result);
        }
    }
}
