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
        public static IEnumerable Sum(this IEnumerable<T> type)
        {
            var result = type;

            return result;
        }
    }
}
