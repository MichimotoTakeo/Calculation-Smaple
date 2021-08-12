using Calculation_Smaple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculationTest
{
    [TestClass]
    public class CalculationTest
    {
        private Calculation calculation = new Calculation();

        [TestMethod]
        public void 足し算のテスト()
        {
            Assert.AreEqual(3, calculation.Add(1, 2));
        }

        [TestMethod]
        public void 引き算のテスト()
        {
            Assert.AreEqual(1, calculation.Subtract(2, 1));
            Assert.AreEqual(0, calculation.Subtract(1, 1));
        }
    }
}
