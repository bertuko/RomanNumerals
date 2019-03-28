using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// One digit
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        [DataRow(9, "IX")]
        /// Two digits
        [DataRow(10, "X")]
        [DataRow(15, "XV")]
        [DataRow(20, "XX")]
        [DataRow(29, "XXIX")]
        [DataRow(34, "XXXIV")]
        [DataRow(99, "XCIX")]
        public void TestMethod1(int number, string romanNumber)
        {
            Assert.AreEqual(romanNumber, number.GetRomanNumber());
        }
    }
}
