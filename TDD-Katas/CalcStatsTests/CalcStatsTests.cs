using System;
using CalcStatsKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcStatsTests
{
    [TestClass]
    public class CalcStatsTests
    {
        private CalcStats _target;
        private int[] _numbers;

        [TestInitialize]
        public void SetupTest()
        {
            _numbers = new int[] {6, 9, 15, -2, 92, 11};
            _target = new CalcStats();
        }

        [TestMethod]
        public void TestMinimum()
        {
            int min = _target.GetMinimum(_numbers);
            Assert.AreEqual(-2, min);
        }

        [TestMethod]
        public void TestMaximum()
        {
            int min = _target.GetMaximum(_numbers);
            Assert.AreEqual(92, min);
        }

        [TestMethod]
        public void TestCount()
        {
            int min = _target.GetCount(_numbers);
            Assert.AreEqual(6, min);
        }

        [TestMethod]
        public void TestAverage()
        {
            double min = _target.GetAverage(_numbers);
            Assert.AreEqual(21.8333333333333, min,0.00000000001);
        }
    }
}
