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
        private double bmi;
        private double height;
        private double weight;
        private BMI_Status status;
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
                CalculateBMI();
                DisplayBMI();
            }

            else
            {
                InputImperialValues();
                ConvertToInchesPounds();
                CalculateBMI();
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
            pounds = ConsoleHelper.InputNumber("\n\tEnter your weight in pounds: ");
            feet = ConsoleHelper.InputNumber("\n\tEnter your height feet: ");
            inches = ConsoleHelper.InputNumber("\n\tEnter your height inches: ");
        }
        /// <summary>
        /// Prompts the user to enter all their key information 
        /// about height and weight with Metric units
        /// </summary>
        private void InputMetricValues()
        {
            kilograms = ConsoleHelper.InputNumber("\n\tEnter your weight in kilograms: ");
            metres = ConsoleHelper.InputNumber("\n\tEnter your height metres: ");
        }
        /// <summary>
        /// This method is used to convert stone to pounds and 
        /// feet to inches
        /// </summary>
        private void ConvertToInchesPounds()
        {
                height = inches + (feet * 12);
                weight = pounds + (stone * 14);
        }
        /// <summary>
        /// This method is used to calculate the BMI value
        /// of the user
        /// </summary>
        private void CalculateBMI()
        {
            if(kilograms > 0)
            {
                bmi = kilograms / (metres * metres);
            }

            else
            {
                bmi = (weight * 703) / (height * height);
            }
        }
        /// <summary>
        /// This method displays the user's BMI value to them
        /// </summary>
        private void DisplayBMI()
        {
            Console.WriteLine($"\n\tYour BMI value is {Math.Round(bmi,2)}");

            if(bmi <= 18.50)
            {
                status = BMI_Status.UnderWeight;
                Console.Write($"\tYour BMI status is {status}");
            }

            else if(bmi <= 24.9)
            {
                status = BMI_Status.NormalWeight;
                Console.WriteLine($"\tYour BMI status is {status}");
            }

            else if(bmi <= 29.9)
            {
                status = BMI_Status.OverWeight;
                Console.WriteLine($"\tYour BMI status is {status}");
            }

            else if(bmi <= 34.9)
            {
                status = BMI_Status.ObeseI;
                Console.WriteLine($"\tYour BMI status is {status}");
            }

            else if(bmi <= 39.9)
            {
                status = BMI_Status.ObeseII;
                Console.WriteLine($"\tYour BMI status is {status}");
            }

            else if(bmi <= 40)
            {
                status = BMI_Status.ObeseIII;
                Console.WriteLine($"\tYour BMI status is {status}");
            }
        }

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
