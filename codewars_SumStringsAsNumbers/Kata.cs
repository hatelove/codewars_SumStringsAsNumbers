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
            var reverseA = GettReverseChars(a);
            var reverseB = GettReverseChars(b);

            var sumOfEachChar = new List<string>();
            var maxLength = Math.Max(a.Length, b.Length);

            for (int i = 0; i < maxLength; i++)
            {
                var sumOfCurrentChar = SumOfSomeChar(reverseA, reverseB, i);
                sumOfEachChar.Add(sumOfCurrentChar);
            }

            sumOfEachChar.Reverse();

            var sum = new StringBuilder();
            sumOfEachChar.ForEach(x => sum.Append(x));

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

        private static char[] GettReverseChars(string originalString)
        {
            return originalString.ToCharArray().Reverse().ToArray();
        }

        private static string SumOfSomeChar(char[] reverseA, char[] reverseB, int index)
        {
            var singleSum = GetNumberByIndex(reverseA, index) + GetNumberByIndex(reverseB, index);
            return singleSum.ToString();
        }
    }
}