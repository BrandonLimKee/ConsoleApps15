using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Brandon Lim-Kee 12/04/2021
    /// </summary>
    public static class Program
    {
        public static DistanceConverter DistanceConverter
        {
            get => default;
            set
            {
            }
        }

        public static BMI_Status BMI_Status
        {
            get => default;
            set
            {
            }
        }
        
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
           

        Console.WriteLine("\tBNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            string[] choices = new string[]
            {
                "Distance Converter",
                "BMI Calculator",
                "Student Grades",
                "Social Network"
            };

            ConsoleHelper.OutputTitle("Enter the application you wish to use");
            int choice = ConsoleHelper.SelectChoice(choices);

            if(choice == 1)
            {
                Console.Clear();
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if(choice == 2)
            {
                Console.Clear();
                BMI cal = new BMI();
                cal.Run();
            }
            else if(choice == 3)
            {
                Console.Clear();
                StudentGrades grades = new StudentGrades();
                grades.Run();
            }
            else if(choice == 4)
            {
                Console.Clear();
                NetworkApp app = new NetworkApp();
                app.Run();
            }
           
            
        }
    }
}
