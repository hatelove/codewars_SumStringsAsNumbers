using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars_SumStringsAsNumbers
{
    internal class Kata
    {
        public static string sumStrings(string a, string b)
        {
            var reverseA = a.ToCharArray().Reverse().ToArray();
            var reverseB = b.ToCharArray().Reverse().ToArray();

            var result = new List<string>();
            var firstSum = SumOfSomeChar(reverseA, reverseB, 0);
            result.Add(firstSum);

            var secondSum = SumOfSomeChar(reverseA, reverseB, 1);
            result.Add(secondSum);

            result.Reverse();

            var sum = new StringBuilder();
            result.ForEach(x => sum.Append(x));

            return sum.ToString().TrimStart('0');
        }

        private static short GetNumberByIndex(char[] chars, int index)
        {
            if (index >= chars.Length)
            {
                return 0;
            }

            return Convert.ToInt16(chars[index].ToString());
        }

        private static string SumOfSomeChar(char[] reverseA, char[] reverseB, int index)
        {
            var singleSum = GetNumberByIndex(reverseA, index) + GetNumberByIndex(reverseB, index);
            return singleSum.ToString();
        }
    }
}