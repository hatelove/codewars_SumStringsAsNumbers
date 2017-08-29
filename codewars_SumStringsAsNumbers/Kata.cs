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
            var reverseA = GetReverseChars(a);
            var reverseB = GetReverseChars(b);

            var sumOfEachChar = SumOfEachChar(reverseA, reverseB);

            return ConcatAllSumStrings(sumOfEachChar).TrimStart('0');
        }

        private static string ConcatAllSumStrings(List<string> sumOfEachChar)
        {
            var sum = new StringBuilder();
            sumOfEachChar.ForEach(x => sum.Append(x));

            return sum.ToString();
        }

        private static short GetNumberByIndex(char[] chars, int index)
        {
            if (index >= chars.Length)
            {
                return 0;
            }

            return Convert.ToInt16(chars[index].ToString());
        }

        private static char[] GetReverseChars(string originalString)
        {
            return originalString.ToCharArray().Reverse().ToArray();
        }

        private static List<string> SumOfEachChar(char[] a, char[] b)
        {
            var sumOfEachChar = new List<string>();
            var maxLength = Math.Max(a.Length, b.Length);

            var isCarry = false;
            for (int i = 0; i < maxLength; i++)
            {
                var carry = isCarry ? 1 : 0;
                var sumOfCurrentChar = SumOfSomeChar(a, b, i) + carry;
                if (sumOfCurrentChar >= 10)
                {
                    isCarry = true;
                    sumOfCurrentChar -= 10;
                }
                else
                {
                    isCarry = false;
                }

                sumOfEachChar.Add(sumOfCurrentChar.ToString());
            }

            if (isCarry)
            {
                sumOfEachChar.Add("1");
            }

            sumOfEachChar.Reverse();
            return sumOfEachChar;
        }

        private static int SumOfSomeChar(char[] reverseA, char[] reverseB, int index)
        {
            var singleSum = GetNumberByIndex(reverseA, index) + GetNumberByIndex(reverseB, index);
            return singleSum;
        }
    }
}