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
    
        public void Run()
        {
            OutputHeading();
            fromUnit = SelectUnit("Enter the unit you would like to convert: ");
            Console.WriteLine("You have selected " + fromUnit);
            toUnit = SelectUnit("Enter the unit you would like to convert to: ");
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("      Distance Converter      ");
            Console.WriteLine("         by Brandon Lim-Kee     ");
            Console.WriteLine("----------------------------------\n");
        }

        private string SelectUnit(string prompt)
        {
            Console.WriteLine("[1] Miles");
            Console.WriteLine("[2] Feet");
            Console.WriteLine("[3] Metres");
            Console.Write(prompt);

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(choice);
            if(choice != 0)
            {
                return ExecuteChoice(choice);
            }  

            else
            {
                return null;
            }
        }

        private string ExecuteChoice(int choice)
        {
            if(choice == 1)
            {
                return "miles";
            }

            else if(choice == 2)
            {
                return "feet";
            }

            else if(choice == 3)
            {
                return "metres";
            }

            else
            {
                return null;
            }
        }

       
    }
}
