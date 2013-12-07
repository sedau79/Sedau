using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalc;

namespace StringCalcTests
{
    [TestClass]
    public class StringCalcTests
    {
        [TestMethod]
        [TestCategory("StringCalc")]
        public void TestEmptyStringSumsUpToZero()
        {
            var target = new StringCalculator();
            Assert.AreEqual(0, target.Add(string.Empty));
        }

        [TestMethod]
        [TestCategory("StringCalc")]
        public void TestNumerInStringSumsUp()
        {
            var target = new StringCalculator();
            Assert.AreEqual(1, target.Add("1"));
        }

        [TestMethod]
        [TestCategory("StringCalc")]
        public void TestNumersInStringSumUp()
        {
            var target = new StringCalculator();
            Assert.AreEqual(66, target.Add("42,24"));
        }

        [TestMethod]
        [TestCategory("StringCalc")]
        public void TestLotsOfNumersInStringSumUp()
        {
            var target = new StringCalculator();
            Assert.AreEqual(131, target.Add("42,24,53,12"));
        }

        [TestMethod]
        [TestCategory("StringCalc")]
        public void TestNumersAndCRLFInStringSumUp()
        {
            var target = new StringCalculator();
            Assert.AreEqual(66, target.Add("42\n,24"));
        }

        [TestMethod]
        [TestCategory("StringCalc")]
        public void TestIfCustomDelimiterWorks()
        {
            var target = new StringCalculator();
            Assert.AreEqual(3, target.Add("//;\n1;2"));
        }
    }
}
