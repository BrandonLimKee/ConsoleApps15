using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
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
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("\tBNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            string[] choices = new string[]
            {
                "Distance Converter",
                "BMI Calculator"
            };

            ConsoleHelper.OutputTitle("Enter the application you wish to use");
            int choice = ConsoleHelper.SelectChoice(choices);

            if(choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }

            else if(choice == 2)
            {
                BMI cal = new BMI();
                cal.Run();
            }

           
            
        }
    }
}
