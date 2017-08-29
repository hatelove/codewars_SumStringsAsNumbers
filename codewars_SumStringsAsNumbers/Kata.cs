using System;
using System.Linq;

namespace codewars_SumStringsAsNumbers
{
    internal class Kata
    {
        public static string sumStrings(string a, string b)
        {
            var singleSum = Convert.ToInt16(a.ToCharArray().First().ToString()) + Convert.ToInt16(b.ToCharArray().First().ToString());

            return singleSum.ToString();
        }
    }
}