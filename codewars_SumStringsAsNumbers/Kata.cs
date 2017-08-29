using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        var sums = Sum(a, b);

        return string.Concat(sums).TrimStart('0');
    }

    private static short GetNumberByIndex(string s, int index)
    {
        if (index >= s.Length)
        {
            return 0;
        }

        return (short)char.GetNumericValue(s, index);
    }

    private static IEnumerable<string> GetSumOfEachChar(string a, string b)
    {
        var maxLength = Math.Max(a.Length, b.Length);

        var isCarry = false;
        for (int i = 0; i < maxLength + 1; i++)
        {
            var carry = isCarry ? 1 : 0;
            var sumOfCurrentChar = GetNumberByIndex(a, i) + GetNumberByIndex(b, i) + carry;

            isCarry = sumOfCurrentChar >= 10;
            sumOfCurrentChar = isCarry ? sumOfCurrentChar - 10 : sumOfCurrentChar;

            yield return sumOfCurrentChar.ToString();
        }
    }

    private static string Reverse(string originalString)
    {
        return new string(originalString.ToCharArray().Reverse().ToArray());
    }

    private static IEnumerable<string> Sum(string a, string b)
    {
        return GetSumOfEachChar(Reverse(a), Reverse(b)).Reverse();
    }
}