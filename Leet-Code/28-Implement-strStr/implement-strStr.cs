using System;
using System.Collections.Generic;

namespace SeparatedInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = StrStr("hello", "ll");
            Console.WriteLine(result);
        }

        private static int StrStr(string haystack, string needle)
        {
            if (needle == String.Empty) return 0;

            if (haystack.Contains(needle)) return haystack.IndexOf(needle);

            return -1;
        }
    }
}
