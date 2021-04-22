using ConsoleAppProject.Helpers;
using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class will convert a given distance into another unit.
    /// The units include Feet, Miles and Metres
    /// </summary>
    /// <author>
    /// Brandon Lim-Kee version 0.1
    /// </author>
    public class DistanceConverter
    {
        private string fromUnit;
        private string toUnit;
        private double fromDistance;
        private double toDistance;
        private int choice;


        /// <summary>
        /// This method will be used to run through all
        /// the methods in a set order as long as "i" is equal to 1
        /// </summary>
        public void Run()
        {
            bool repeat = true;
            while (repeat)
            {
                OutputHeading();
                DisplayUnits();
                choice = (int)ConsoleHelper.InputNumber("Enter the unit you would like to convert: ",1,3);
                fromUnit = ExecuteChoice(choice);
                Console.WriteLine("You have selected " + fromUnit);

                DisplayUnits();
                choice = (int)ConsoleHelper.InputNumber("Enter the unit you would like to convert: ", 1, 3);
                toUnit = ExecuteChoice(choice);
                Console.WriteLine("You have selected " + toUnit);

                fromDistance = InputDistance();
                toDistance = CalculateDistance();
                Console.WriteLine(toDistance);

                repeat = SelectRepeat();

            }
            
        }
        /// <summary>
        /// This method outputs a heading to the user
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("      Distance Converter      ");
            Console.WriteLine("         by Brandon Lim-Kee     ");
            Console.WriteLine("----------------------------------\n");
        }
 
        
        /// <summary>
        /// Depending on what choice is equal to 
        /// the method will retrun a unit
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private string ExecuteChoice(int choice)
        {
            if (choice == 1)
            {
                return "miles";
            }

            else if (choice == 2)
            {
                return "feet";
            }

            else if (choice == 3)
            {
                return "metres";
            }

            else
            {
                return null;
            }
        }
        /// <summary>
        /// This method prompts the user to input an 
        /// amount for the unit they are going to convert
        /// </summary>
        /// <returns></returns>
        private double InputDistance()
        {
            return ConsoleHelper.InputNumber($"Enter the number of {fromUnit} : ");
        }
        /// <summary>
        /// This method calculates the distance for the user
        /// depending on what units they have chosen and returns
        /// the result
        /// </summary>
        /// <returns></returns>
        private double CalculateDistance()
        {
            if (fromUnit == "miles" && toUnit == "feet")
            {
                return fromDistance * 5280;
            }

            else if (fromUnit == "miles" && toUnit == "metres")
            {
                return fromDistance * 1609.34;
            }

            else if (fromUnit == "Feet" && toUnit == "miles")
            {
                return fromDistance / 5280;
            }

            else if (fromUnit == "Feet" && toUnit == "metres")
            {
                return fromDistance / 3.28084;
            }

            else if (fromUnit == "metres" && toUnit == "feet")
            {
                return fromDistance * 3.28084;
            }

            else if (fromUnit == "metres" && toUnit == "miles")
            {
                return fromDistance / 1609.34;
            }

            else
            {
                return 0;
            }
        }
        /// <summary>
        /// This method displays the different
        /// units to the user: Miles,Feet and Metres
        /// </summary>
        private void DisplayUnits()
        {
            Console.WriteLine("[1] Miles");
            Console.WriteLine("[2] Feet");
            Console.WriteLine("[3] Metres");
        }

        private bool SelectRepeat()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("You would you like to carry out" +
                    "another calculation?Y/N");
                string choice = Console.ReadLine();

                if (choice.ToLower().Contains("y"))
                {
                    Console.WriteLine("You have selected yes");
                    repeat = false;
                    return true;
                    
                }

                else if (choice.ToLower().Contains("n"))
                {
                    Console.WriteLine("You have selected no");
                    repeat = false;
                    return false;
                }

                else
                {
                    Console.WriteLine("Error: invalid input. Please try again");

                }

            }
            return false;
        }

    }
}
