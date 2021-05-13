using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleAppTests
{
    [TestClass]
   public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        private int[] testMarks;

        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = converter.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = converter.ConvertToGrade(39);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert40ToGradeD()
        {
            Grades expectedGrade = Grades.D;
            Grades actualGrade = converter.ConvertToGrade(40);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert49ToGradeD()
        {
            Grades expectedGrade = Grades.D;
            Grades actualGrade = converter.ConvertToGrade(49);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert50ToGradeC()
        {
            Grades expectedGrade = Grades.C;
            Grades actualGrade = converter.ConvertToGrade(50);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert59ToGradeC()
        {
            Grades expectedGrade = Grades.C;
            Grades actualGrade = converter.ConvertToGrade(59);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert60ToGradeB()
        {
            Grades expectedGrade = Grades.B;
            Grades actualGrade = converter.ConvertToGrade(60);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert69ToGradeB()
        {
            Grades expectedGrade = Grades.B;
            Grades actualGrade = converter.ConvertToGrade(69);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert70ToGradeA()
        {
            Grades expectedGrade = Grades.A;
            Grades actualGrade = converter.ConvertToGrade(70);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert100ToGradeA()
        {
            Grades expectedGrade = Grades.A;
            Grades actualGrade = converter.ConvertToGrade(100);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            converter.Marks = testMarks;
            double expectedMean = 55.0;
            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public void TestCalculateMinimum()
        {
            converter.Marks = testMarks;
            int expectedMinimum = 10;
            converter.CalculateStats();

            Assert.AreEqual(expectedMinimum, converter.Minimum);
        }

        [TestMethod]
        public void TestCalculateMaximum()
        {
            converter.Marks = testMarks;
            int expectedMaximum = 100;
            converter.CalculateStats();

            Assert.AreEqual(expectedMaximum, converter.Maximum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            converter.Marks = testMarks;
            converter.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 3) &&
                               (converter.GradeProfile[1] == 1) &&
                               (converter.GradeProfile[2] == 1) &&
                               (converter.GradeProfile[3] == 1) &&
                               (converter.GradeProfile[4] == 4));

            Assert.IsTrue(expectedProfile);    
        }
    }
}
