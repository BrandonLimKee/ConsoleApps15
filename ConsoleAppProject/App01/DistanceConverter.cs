using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
    
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CaluculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.Write("\n------------------------");
            Console.Write("      Convert Miles to feet      ");
            Console.Write("      by Brandon Lim-Kee     ");
            Console.Write("\n------------------------\n");
        }

        private void InputMiles()
        {
            Console.Write("Please enter the number of miles: ");
            String value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CaluculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is equal to " + feet + " feet");
        }
    }
}
