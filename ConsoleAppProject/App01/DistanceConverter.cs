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
        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;
        private double fromDistance;
        private double toDistance;
        private int choice;
        private int prevChoice;


        /// <summary>
        /// This method will be used to run through all
        /// the methods in a set order as long as "i" is equal to 1
        /// </summary>
        public void Run()
        {
            bool repeat = true;
            while (repeat)
            {
                ConsoleHelper.OutputHeading("Distance Converter");
                DisplayUnits();
                choice = (int)ConsoleHelper.InputNumber("\n\tEnter the unit you would like to convert: ",1,3);
                prevChoice = choice;
                fromUnit = ExecuteChoice(choice);
                Console.WriteLine("\n\tYou have selected " + fromUnit + "\n");

                bool loop = true;
                while (loop)
                {
                    DisplayUnits();
                    choice = (int)ConsoleHelper.InputNumber("\n\tEnter the unit you would like to convert to: ", 1, 3);

                    loop = CheckSameUnit(choice,prevChoice);
                }
                toUnit = ExecuteChoice(choice);
                Console.WriteLine("\n\tYou have selected " + toUnit);
                
                fromDistance = ConsoleHelper.InputNumber($"\n\tEnter number of {fromUnit}: ");
                toDistance = CalculateDistance();
                Console.WriteLine($"\n\t{fromDistance} {fromUnit} is equal to {toDistance} {toUnit}\n");
                repeat = SelectRepeat();

            }
            
        }
        /// <summary>
        /// This method outputs a heading to the user
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n\t----------------------------------");
            Console.WriteLine("\t        Distance Converter      ");
            Console.WriteLine("\t         by Brandon Lim-Kee     ");
            Console.WriteLine("\t----------------------------------\n");
        }
 
        
        /// <summary>
        /// Depending on what choice is equal to 
        /// the method will retrun a unit
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private DistanceUnits ExecuteChoice(int choice)
        {
            if (choice == 1)
            {
                return DistanceUnits.Miles;
            }

            else if (choice == 2)
            {
                return DistanceUnits.Feet;
            }

            else if (choice == 3)
            {
                return DistanceUnits.Metres;
            }

            else
            {
                return DistanceUnits.NoUnit;
            }
        }
  
        /// <summary>
        /// This method calculates the distance for the user
        /// depending on what units they have chosen and returns
        /// the result
        /// </summary>
        /// <returns></returns>
        private double CalculateDistance()
        {
            if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                return fromDistance * 5280;
            }

            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            {
                return fromDistance * 1609.34;
            }

            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                return fromDistance / 5280;
            }

            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
            {
                return fromDistance / 3.28084;
            }

            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
            {
                return fromDistance * 3.28084;
            }

            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
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
            Console.WriteLine("\t[1] Miles");
            Console.WriteLine("\t[2] Feet");
            Console.WriteLine("\t[3] Metres");
        }

        private bool SelectRepeat()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.Write("\tWould you like to carry out" +
                    "another calculation?Y/N: ");
                string choice = Console.ReadLine();

                if (choice.ToLower().Contains("y"))
                {
                    Console.WriteLine("\tYou have selected yes");
                    repeat = false;
                    return true;
                    
                }

                else if (choice.ToLower().Contains("n"))
                {
                    Console.WriteLine("\tYou have selected no");
                    repeat = false;
                    return false;
                }

                else
                {
                    Console.WriteLine("\tError: invalid input. Please try again");

                }

            }
            return false;
        }

        private bool CheckSameUnit(int a, int b)
        {
            if(a == b)
            {
                Console.WriteLine("\n\tYou have tried to convert a unit into the same unit\n");
                return true;
            }

            else if(a != b)
            {
                return false;
            }

            return false;
        }
    }
}
