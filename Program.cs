using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Looping_Proplems
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            int min1;
            int max1;
            int between;
            Console.WriteLine("1.");
            Console.WriteLine();

            //Min
            Console.Write("Enter an integer: ");
            while (!Int32.TryParse(Console.ReadLine(), out min1))
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Enter an integer: ");
            }

            //Max
            Console.Write($"Enter an integer greater than {min1}: ");
            while (!Int32.TryParse(Console.ReadLine(), out max1) || max1 < min1)
            {
                Console.WriteLine("Invalid input.");
                Console.Write($"Enter an integer greater than {min1}: ");
            }

            //Between
            Console.Write($"Enter an integer between {min1} and {max1}: ");
            while (!Int32.TryParse(Console.ReadLine(), out between) || between < min1 || between > max1)
            {
                Console.WriteLine("Invalid input");
                Console.Write($"Enter an integer between {min1} and {max1}: ");
            }

            //Output
            Console.WriteLine($"{between} is an integer between {min1} and {max1}.");
            Console.WriteLine();

            //2.
            int totalScoreInputs = 0;
            int totalPassingScores = 0;
            string userInput;
            int tempGrade;
            bool done = false;
            Console.WriteLine("2.");

            while (!done)
            {
                Console.Write("Enter a grade in % (do not type %) as an integer, or enter q to stop entering grades: ");
                userInput = Console.ReadLine();
                if ((userInput.Trim().ToLower() == "q"))
                {
                    if (totalScoreInputs == 0)
                    {
                        Console.WriteLine("You did not enter any grades.");
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Round(Convert.ToDouble(totalPassingScores) / Convert.ToDouble(totalScoreInputs) * 100.0, 2)}% of you grades were above 70%.");
                        done = true;
                    }
                }
                else
                {
                    if (Int32.TryParse(userInput, out tempGrade))
                    {
                        if (tempGrade > 100 || tempGrade < 0)
                            Console.WriteLine("It is impossible to get that grade!");
                        else
                        {
                            totalScoreInputs += 1;
                            if (tempGrade >= 70)
                                totalPassingScores += 1;
                        }
                    }
                    else
                        Console.WriteLine("Invalid Input.");

                }
            }
            Console.WriteLine();

            //3.
            int input;
            int sum = 0;
            Console.Write("Enter an integer to see the sum of all odd numbers between 0 and that number: ");
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid Input.");
                Console.Write("Enter an integer to see the sum of all odd numbers between 0 and that number: ");
            }
            if (input >= 0)
            {
                for (int i = 0; i <= input; i++)
                {
                    if (i % 2 != 0)
                        sum += i;
                }
            }
            else
            {
                for (int i = 0; i >= input; i--)
                {
                    if (i % 2 != 0)
                        sum += i;
                }
            }
            Console.WriteLine($"The sum of all odd numbers from 0 to {input} (Inclusive) is {sum}");
            Console.WriteLine();

            //4.
            int min4;
            int max4;
            Random rng = new Random();
            Console.Write("Enter the minimum value (As an integer) for your 25 random integers: ");
            while (!Int32.TryParse(Console.ReadLine(), out min4))
            {
                Console.WriteLine("Invalid Input");
                Console.Write("Enter the minimum value (As an integer) for your 25 random integers: ");
            }
            Console.WriteLine($"Minimum value of {min4} selected.");
            Console.Write("Enter the maximum value (As an integer) for your 25 random integers: ");
            while (!Int32.TryParse(Console.ReadLine(), out max4))
            {
                Console.WriteLine("Invalid Input");
                Console.Write("Enter the maximun value (As an integer) for your 25 random integers: ");
            }
            Console.WriteLine($"Maximum value of {max4} selected.");
            Console.WriteLine();
            Console.WriteLine("Your 25 random integers:");
            for (int i = 0; i <= 24; i++)
            {
                Console.WriteLine(rng.Next(min4, max4 + 1));
            }
            Console.ReadLine();
        }
    }
}
