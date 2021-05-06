using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace TestProject2
{
    [TestClass]
    public class TestBMI
    {
        [TestMethod]
        public void TestLowestUnderweight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.93;
            calculator.Weight = 45.5;

            calculator.CalculateBMI();
            calculator.DisplayBMI();

            double expectedBMI = 12.22;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

    }   
}