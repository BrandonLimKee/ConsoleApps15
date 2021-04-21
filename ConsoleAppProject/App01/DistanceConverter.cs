using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The app is a distance converter that will convert a given mesaurement 
    /// into another.
    /// </summary>
    /// <author>
    /// Brandon Lim-Kee version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
    
        public void Run()
        {
            OutputHeading();
            SelectChoice();
            //InputMiles();
            //CaluculateFeet();
           // OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("      Convert Miles to feet      ");
            Console.WriteLine("         by Brandon Lim-Kee     ");
            Console.WriteLine("----------------------------------\n");
        }

        private int SelectChoice()
        {
            Console.WriteLine("[1] Miles");
            Console.WriteLine("[2] Feet");
            Console.Write("Please enter the unit you would like to convert: ");

            int choice = Console.Read();

            return choice;
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
