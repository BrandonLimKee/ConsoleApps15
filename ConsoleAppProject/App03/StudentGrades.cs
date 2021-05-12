using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        public string[] Students { get; set; }

        public int [] Marks { get; set; }

        public int [] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Kindra","Adriene","Honey",
                "Hugo","Gale","Robin",
                "Dante","Cole","Julia",
                "Yuko"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// 
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a Grade based on the value of a given mark
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else return Grades.C;
        }

        private void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;

            foreach(int mark in Marks)
            {
                total = total + mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        public void TestGradesEnumeration()
        {
            Grades grade = Grades.C;

            Console.WriteLine($"Grade = {grade}");
            Console.WriteLine($"Grade No = {(int)grade}");

            Console.WriteLine("\nDiscovered by Andrei!\n");
            var gradeName = grade.GetAttribute<DisplayAttribute>().Name;
            Console.WriteLine($"Grade Name = {gradeName}");

            var gradeDescription = grade.GetAttribute<DescriptionAttribute>().Description;
            Console.WriteLine($"Grade Description = {gradeDescription}");

            string testDescription = EnumHelper<Grades>.GetDescription(grade);
            string testName = EnumHelper<Grades>.GetName(grade);

            Console.WriteLine();
            Console.WriteLine("Discovered by Derek Using EnumHelper\n");
            Console.WriteLine($"Name = {testName}");
            Console.WriteLine($"Description = {testDescription}");

        }
    }
}
