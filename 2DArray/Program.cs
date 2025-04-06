
// See https;//aka.ms/new-console-template for more information

using System;

namespace MyApp
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            const int LOW_NUMBER = 0;
            const int HIGH_NUMBER = 100;
            const string arrayFigure1 = "X";
            const string arrayFigure2 = "O";
            const int SYMBOL_VARIABLE = 1;
            const int NUMBER_VARIABLE = 2;
            const int OTHER_VARIABLE = 3;
            bool assign = false;
            int randomRows = rng.Next(LOW_NUMBER, HIGH_NUMBER);
            int randomColumns = rng.Next(LOW_NUMBER, HIGH_NUMBER);


            Console.WriteLine($"Enter {SYMBOL_VARIABLE} for X and O");
            Console.WriteLine($"Please enter {NUMBER_VARIABLE} for numbers");
            Console.WriteLine($"Enter {OTHER_VARIABLE} for OTHER");
            int userChoice = int.Parse(Console.ReadLine());



            Console.WriteLine($"A random row will generate: {randomRows}");
            Console.WriteLine($"A random column will generate: {randomColumns}");

            int[,] numbers = new int[randomRows, randomColumns];


            for (int i = 0; i < randomRows; i++)
            {
                for (int j = 0; j < randomColumns; j++)
                {
                    numbers[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                }
            }

            Console.WriteLine("Here is your 2D array:");

            if (userChoice == SYMBOL_VARIABLE)
            {

                for (int i = 0; i < randomRows; i++)
                {
                    for (int j = 0; j < randomColumns; j++)
                    {
                        if (numbers[i, j] % 2 == 0)
                        {
                            Console.Write(arrayFigure2.PadLeft(4));
                        }
                        else
                        {
                            Console.Write(arrayFigure1.PadLeft(4));
                        }
                    }

                    Console.WriteLine();
                }
            }

            else if (userChoice == NUMBER_VARIABLE)
            {
                for (int i = 0; i < randomRows; i++)
                {
                    for (int j = 0; j < randomColumns; j++)
                    {
                        Console.Write(numbers[i, j].ToString().PadLeft(4));
                    }

                    Console.WriteLine();
                }
            }
            else if (userChoice == OTHER_VARIABLE)
                for (int i = 0; i < randomRows; i++)
                {
                    for (int j = 0; j < randomColumns; j++)
                    {
                        if (numbers[i, j] % 2 == 3)
                        {
                            Console.Write(arrayFigure2.PadLeft(4));
                        }
                        else
                        {
                            Console.Write(arrayFigure1.PadLeft(4));
                        }
                    }
                }
            else

            {
                        Console.WriteLine("Invalid input. Please restart and enter 1 or 2.");
            }

        }
    } 
}

