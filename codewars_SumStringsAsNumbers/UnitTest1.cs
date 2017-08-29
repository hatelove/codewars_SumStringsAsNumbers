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
            var a = "1";
            var b = "2";
            var expected = 3;
            int actual = Kata.sumStrings(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
