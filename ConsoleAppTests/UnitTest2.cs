using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace TestProject2
{
    [TestClass]
    public class TestBMI
    {
        [TestMethod]
        public void TestMetricLowestUnderWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.93;
            calculator.Weight = 45.5;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();
            

            double expectedBMI = 12.22;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricHeighestUnderWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.574;
            calculator.Weight = 45.5;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 18.37;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricLowestNormalWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.93;
            calculator.Weight = 70.5;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 18.93;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricHeighestNormalWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 56.8;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 24.46;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricLowestOverWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 59.1;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 25.45;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricHeighestOverWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 68.2;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 29.36;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricLowestObeseIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 70.5;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 30.35;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricHeighestObeseIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 79.5;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 34.23;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricLowestObeseIIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 81.8;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 35.22;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricHeighestObeseIIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 90.9;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 39.14;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricLowestObeseIIIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 93.2;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 40.13;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestMetricHeighestObeseIIIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 1.524;
            calculator.Weight = 97.7;

            calculator.CalculateMetricBMI();
            calculator.DisplayBMI();


            double expectedBMI = 42.07;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialLowestUnderWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 6.4*12;
            calculator.Weight = 100;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 11.92;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialHeighestUnderWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 6.4*12;
            calculator.Weight = 150;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 17.88;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialLowestNormalWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 6.4 * 12;
            calculator.Weight = 155;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 18.47;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialHeighestNormalWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 6.4 * 12;
            calculator.Weight = 200;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 23.84;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialLowestOverWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 5 * 12;
            calculator.Weight = 130;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 25.39;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialHeighestOverWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 5 * 12;
            calculator.Weight = 150;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 29.29;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialLowestObeseIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 5 * 12;
            calculator.Weight = 155;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 30.27;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialHeighestObeseIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 5 * 12;
            calculator.Weight = 175;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 34.17;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialLowestObeseIIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 5 * 12;
            calculator.Weight = 180;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 35.15;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialHeighestObeseIIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 5 * 12;
            calculator.Weight = 200;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 39.06;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialLowestObeseIIIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 5 * 12;
            calculator.Weight = 205;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 40.03;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        [TestMethod]
        public void TestImperialHeighestObeseIIIWeight()
        {
            BMI calculator = new BMI();

            calculator.Height = 5 * 12;
            calculator.Weight = 215;

            calculator.CalculateImperialBMI();
            calculator.DisplayBMI();


            double expectedBMI = 41.98;

            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }
    }   
}