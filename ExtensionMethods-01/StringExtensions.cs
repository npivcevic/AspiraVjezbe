using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_01
{
    internal static class StringExtensions
    {
        public static string Pluralize(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char lastChar = str[str.Length - 1];

            if (lastChar == 's')
                return str + "es";

            return str + "s";

        }
    }
}
