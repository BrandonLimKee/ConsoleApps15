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
        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit  { get; set; }
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
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
                FromUnit = ExecuteChoice(choice);
                Console.WriteLine("\n\tYou have selected " + FromUnit + "\n");

                bool loop = true;
                while (loop)
                {
                    DisplayUnits();
                    choice = (int)ConsoleHelper.InputNumber("\n\tEnter the unit you would like to convert to: ", 1, 3);

                    loop = CheckSameUnit(choice,prevChoice);
                }
                ToUnit = ExecuteChoice(choice);
                Console.WriteLine("\n\tYou have selected " + ToUnit);
                
                FromDistance = ConsoleHelper.InputNumber($"\n\tEnter number of {FromUnit}: ");
                ToDistance = CalculateDistance();
                Console.WriteLine($"\n\t{FromDistance} {FromUnit} is equal to {ToDistance} {ToUnit}\n");
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
        public double CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                return FromDistance * 5280;
            }

            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                return FromDistance * 1609.34;
            }

            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                return FromDistance / 5280;
            }

            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                return FromDistance / 3.28084;
            }

            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                return FromDistance * 3.28084;
            }

            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                return FromDistance / 1609.34;
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
