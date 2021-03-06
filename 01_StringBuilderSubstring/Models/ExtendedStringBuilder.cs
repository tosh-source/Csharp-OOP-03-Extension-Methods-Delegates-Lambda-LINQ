﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ExtendedStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int index, int length)
        {
            var result = new StringBuilder();

            result.Append(stringBuilder.ToString(index, length));  //Cool thing is that 'ToString()' implementation in StringBuilder have same functionality as Substring (form String class)!

            return result;
        }
    }
}
