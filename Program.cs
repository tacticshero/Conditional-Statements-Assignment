using System;
//Assignment: Deliverable (2) Conditional Statement
//Date: 9/6/22
namespace Conditional_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = false;

            while (success == false) //The program will keep prompting the user until valid input is entered.
            {
                int percent_grade;

                Console.WriteLine("Enter your Percentage Grade as an Integer:");
                string input = Console.ReadLine();

                success = int.TryParse(input, out percent_grade);

                if (success)
                {
                    if (percent_grade >= 0 & percent_grade <= 100)
                    {
                        char letter_grade = 'N';
                        if (percent_grade >= 90)
                        {
                            letter_grade = 'A';
                        }
                        else if (percent_grade >= 80)
                        {
                            letter_grade = 'B';
                        }
                        else if (percent_grade >= 70)
                        {
                            letter_grade = 'C';
                        }
                        else if (percent_grade >= 60)
                        {
                            letter_grade = 'D';
                        }
                        else if (percent_grade >= 0 & percent_grade < 60)
                        {
                            letter_grade = 'F';
                        }
                        Console.WriteLine("You received a " + char.ToString(letter_grade) + " in the class.");
                    }
                    else // Invalid Input 1: User enters an integer less than 0 or greater than 100.
                    {
                        Console.WriteLine("Enter an integer between 0 and 100");
                        success = false;
                    }
                }
                else // Invalid Input 2: User enters a data type that cannot be parsed into an integer.
                {
                    Console.WriteLine("Enter an integer between 0 and 100");
                }
            }
        }
    }
}