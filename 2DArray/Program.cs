
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
            int randomNumber = rng.Next(LOW_NUMBER, HIGH_NUMBER);
            bool assign = false;
            int randomRows = rng.Next(LOW_NUMBER, HIGH_NUMBER);
            int randomColumns = rng.Next(LOW_NUMBER, HIGH_NUMBER);


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
    }
}