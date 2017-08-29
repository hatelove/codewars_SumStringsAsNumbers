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

        [TestMethod]
        public void string_4_and_8_should_be_12()
        {
            SumShouldBe("4", "8", "12");
        }

        [TestMethod]
        public void string_24_and_3_should_be_27()
        {
            SumShouldBe("24", "3", "27");
        }

        private static void SumShouldBe(string a, string b, string expected)
        {
            string actual = Kata.sumStrings(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}