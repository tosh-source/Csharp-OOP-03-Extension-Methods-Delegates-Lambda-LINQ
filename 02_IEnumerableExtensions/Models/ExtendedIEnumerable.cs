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
        public static decimal CollectionSum<T>(this IEnumerable<T> type)
        {
            ExceptionHandler(type);
            decimal result = 0;

            foreach (var item in type)
            {
                result += decimal.Parse(item.ToString());
            }

            return result;
        }

        public static decimal CollectionProduct<T>(this IEnumerable<T> type)
        {
            ExceptionHandler(type);
            decimal result = 1;

            foreach (var item in type)
            {
                result *= decimal.Parse(item.ToString());
            }

            return result;
        }

        public static decimal CollectionMin<T>(this IEnumerable<T> type)
        {
            ExceptionHandler(type);
            decimal result = 0;

            result = decimal.Parse(type.Min().ToString());

            return result;
        }

        public static decimal CollectionMax<T>(this IEnumerable<T> type)
        {
            ExceptionHandler(type);
            decimal result = 0;

            result = decimal.Parse(type.Max().ToString());

            return result;
        }

        public static decimal CollectionAverage<T>(this IEnumerable<T> type)
        {
            ExceptionHandler(type);
            decimal result = 0;
            int counter = 0;

            foreach (var item in type)
            {
                result += decimal.Parse(item.ToString());
                counter++;
            }
            result = result / counter;

            return result;
        }

        private static void ExceptionHandler(IEnumerable type)
        {
            if (type == null)
            {
                throw new ArgumentException("Empty Collection!!!");
            }

            foreach (var item in type)
            {
                if (!(item is ValueType))
                {
                    throw new ArgumentException("Only ValueTypes can be calculated!");
                }
            }
        }
    }
}
