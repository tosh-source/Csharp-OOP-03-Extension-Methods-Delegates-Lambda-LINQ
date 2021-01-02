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
        public static IEnumerable Sum<T>(this IEnumerable<T> type)
        {
            List<T> typeToList = type.ToList();
            var result = typeToList.Sum();
                
            return result;
        }
    }
}
