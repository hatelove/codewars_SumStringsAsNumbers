using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codewars_SumStringsAsNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void string_1_and_2_sum_Should_be_3()
        {
            SumShouldBe("1", "2", "3");
        }

        private static void SumShouldBe(string a, string b, string expected)
        {
            string actual = Kata.sumStrings(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
