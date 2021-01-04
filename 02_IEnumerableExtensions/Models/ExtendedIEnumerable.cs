using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ExtendedIEnumerable
    {
        public static decimal SumOfCollection<T>(this IEnumerable<T> type)
        {
            decimal result = 0;

            foreach (var item in type)
            {
                if (item is ValueType)
                {
                    result += decimal.Parse(item.ToString());
                }
                else
                {
                    throw new ArgumentException("Only ValueTypes can be calculated!");
                }
            }
                
            return result;
        }
    }
}
