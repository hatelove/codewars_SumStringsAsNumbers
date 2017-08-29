using System;
using System.Linq;

namespace codewars_SumStringsAsNumbers
{
    internal class Kata
    {
        public static string sumStrings(string a, string b)
        {
            var singleSum = GetFirstNumber(a) + GetFirstNumber(b);

            return singleSum.ToString();
        }

        private static short GetFirstNumber(string a)
        {
            return Convert.ToInt16(a.ToCharArray().First().ToString());
        }
    }
}