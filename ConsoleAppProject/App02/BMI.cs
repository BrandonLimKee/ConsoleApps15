using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will take the height and weight from 
    /// the user and will display their BMI
    /// </summary>
    /// <author>
    /// Brandon Lim-Kee version 1.0
    /// </author>
    public class BMI
    {
        private int choice;
        private double kilograms;
        private double pounds;
        private double feet;
        private double inches;
        private double metres;
        private double stone;
        public double Bmi { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public BMI_Status Status { get; set; }

        public BMI_Status BMI_Status
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method will be used to run through all the 
        /// methods in a set order
        /// </summary>
        public void Run()
        {
            bool repeat = true;
            while (repeat)
            {
                ConsoleHelper.OutputHeading("BMI Calculator");
                DisplayUnits();
                choice = (int)ConsoleHelper.InputNumber("\n\tEnter the unit you would like to convert: ", 1, 3);
                ExcecuteChoice(choice);

                repeat = SelectRepeat();
            }
        }
        /// <summary>
        /// This method displays the choice of metric and 
        /// imperial units to the user
        /// </summary>
        private void DisplayUnits()
        {
            Console.WriteLine("\t[1] Metric");
            Console.WriteLine("\t[2] Imperial"); 
        }
        /// <summary>
        /// When given a choice this method will excecute a set
        /// of methods depending on what choice is equal to
        /// </summary>
        /// <param name="choice"></param>
        private void ExcecuteChoice(int choice)
        {
            if(choice == 1)
            {
                InputMetricValues();
                CalculateMetricBMI();
                DisplayBMI();
            }

            else
            {
                InputImperialValues();
                ConvertToInchesPounds();
                CalculateImperialBMI();
                DisplayBMI();
            }
        }
        /// <summary>
        /// Prompts the user to enter all their key information 
        /// about height and weight with Imperial units
        /// </summary>
        private void InputImperialValues()
        {
            stone = ConsoleHelper.InputNumber("\n\tEnter your weight in stone: ");
            pounds = ConsoleHelper.InputNumber("\n\tEnter your weight in pounds: ",90, 290);
            feet = ConsoleHelper.InputNumber("\n\tEnter your height feet: ",4, 6);
            inches = ConsoleHelper.InputNumber("\n\tEnter your height inches: ",0, 12);
        }
        /// <summary>
        /// Prompts the user to enter all their key information 
        /// about height and weight with Metric units
        /// </summary>
        private void InputMetricValues()
        {
            kilograms = ConsoleHelper.InputNumber("\n\tEnter your weight in kilograms: ",41, 132);
            metres = ConsoleHelper.InputNumber("\n\tEnter your height metres: ",1.42, 2.10);

            Weight = kilograms;
            Height = metres;
        }
        /// <summary>
        /// This method is used to convert stone to pounds and 
        /// feet to inches
        /// </summary>
        private void ConvertToInchesPounds()
        {
                Height = inches + (feet * 12);
                Weight = pounds + (stone * 14);
        }
        /// <summary>
        /// This method is used to calculate the BMI value
        /// of the user
        /// </summary>
        public void CalculateImperialBMI()
        {

                Bmi = (Weight * 703) / (Height * Height);
            
        }

        public void CalculateMetricBMI()
        {
          
                Bmi = Weight / (Height * Height);
            

        }
        /// <summary>
        /// This method displays the user's BMI value to them
        /// </summary>
        public void DisplayBMI()
        {
            Bmi = Math.Round(Bmi, 2);

            Console.WriteLine($"\n\tYour BMI value is {Bmi}");

            if(Bmi <= 18.50)
            {
                Status = BMI_Status.UnderWeight;
                ///Console.Write($"\tYour BMI status is {status}");
                DisplayBMIMessage(Status);
            }

            else if(Bmi <= 24.9)
            {
                Status = BMI_Status.NormalWeight;
                DisplayBMIMessage(Status);
            }

            else if(Bmi <= 29.9)
            {
                Status = BMI_Status.OverWeight;
                DisplayBMIMessage(Status);
            }

            else if(Bmi <= 34.9)
            {
                Status = BMI_Status.ObeseI;
                DisplayBMIMessage(Status);
            }

            else if(Bmi <= 39.9)
            {
                Status = BMI_Status.ObeseII;
                DisplayBMIMessage(Status);
            }

            else if(Bmi <= 40)
            {
                Status = BMI_Status.ObeseIII;
                DisplayBMIMessage(Status);
            }
        }
        /// <summary>
        /// Displays the user's bmi status and a BAME message
        /// </summary>
        /// <param name="status"></param>
        private void DisplayBMIMessage(BMI_Status status)
        {
            Console.WriteLine($"\tYour BMI status is {status}");
            Console.WriteLine("\n\tIf you are Black, Asian or other" +
                "minority ethnic groups, you have a higher risk\n");

        }
        /// <summary>
        /// Gives the user a choice if they want to carry out
        /// another calculation or close the program
        /// </summary>
        /// <returns></returns>
        private bool SelectRepeat()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.Write("\tWould you like to carry out" +
                    "another testY/N: ");
                string choice = Console.ReadLine();

                if(choice.ToLower().Contains("y"))
                {
                    return true;
                }

                else if(choice.ToLower().Contains("n"))
                {
                    return false;
                }

                else
                {
                    Console.WriteLine("\t\nInvalid input please try again");
                }             
            }
            return false;
        }

    }
}
