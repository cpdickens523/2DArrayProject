// See https://aka.ms/new-console-template for more information

using System;



namespace MyApp
{
    public class UIMethod
    {
        public static void DisplayWelcomeMessage()
        {
            throw new NotImplementedException();
        }

        public static bool MakeDecision()
        {
            throw new NotImplementedException();
        }
    }
    
    UIMethod.DisplayWelcomeMessage();
    internal class Program
    
    if UIMethod.MakeDecision()== false)
    { 
        Environment.Exit(0);
    }
    
    {
        static void Main(string[] args)
        {
            
            Random rng = new Random();
            const int LOW_NUMBER = 1;
            const int HIGH_NUMBER = 3;
            const string ARRAY_FIGURE_1 = "X";
            const string ARRAY_FIGURE_2 = "O";
            const int SYMBOL_VARIABLE = 1;
            const int NUMBER_VARIABLE = 2;
            const int OTHER_VARIABLE = 3;

            int threeRows = LOW_NUMBER * HIGH_NUMBER;
            int threeColumns = LOW_NUMBER * HIGH_NUMBER;

            Console.WriteLine($"Enter {SYMBOL_VARIABLE} for X and O");
            Console.WriteLine($"Please enter {NUMBER_VARIABLE} for numbers");
            Console.WriteLine($"Enter {OTHER_VARIABLE} for OTHER");
            int userChoice = int.Parse(Console.ReadLine());

            Console.WriteLine($"A random row will generate: {threeRows}");
            Console.WriteLine($"A random column will generate: {threeColumns}");

            int[,] numbers = new int[threeRows, threeColumns];

            for (int i = 0; i < threeRows; i++)
            {
                for (int j = 0; j < threeColumns; j++)
                {
                    numbers[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                }
            }
            Console.WriteLine("Here is your 2D array:");
         


            string horizontalBorder = new string('#', (threeColumns * 4) + 2);
            string verticalBorder = new string('#', (threeRows * 4) + 2);
            
        

            if (userChoice == SYMBOL_VARIABLE)
            {
                Console.WriteLine(verticalBorder);

                for (int i = 0; i < threeRows; i++)
                {
                    Console.Write("#");
                    
                    for (int j = 0; j < threeColumns; j++)
                    {
                        if (numbers[i, j] % 2 == 0)
                        {
                            Console.Write(ARRAY_FIGURE_2.PadLeft(4));
                        }
                        else
                        {
                            Console.Write(ARRAY_FIGURE_1.PadLeft(4));
                        }
                    }

                    Console.WriteLine("#");
                }

                Console.WriteLine(horizontalBorder);
            }
            else if (userChoice == NUMBER_VARIABLE)
            {
                Console.WriteLine(horizontalBorder);
                Console.Write("#");

                for (int i = 0; i < threeRows; i++)
                {
                    Console.Write("#");
                    for (int j = 0; j < threeColumns; j++)
                    {
                        Console.Write(numbers[i, j].ToString().PadLeft(4));
                    }
                    Console.WriteLine("#");
                }

                Console.WriteLine(horizontalBorder);
            }
            
            else if (userChoice == OTHER_VARIABLE)
            {
                Console.WriteLine(horizontalBorder);
                
                Console.Write("#");

                for (int i = 0; i < threeRows; i++)
                {
                    Console.Write("#");
                    for (int j = 0; j < threeColumns; j++)
                    {
                        if (numbers[i, j] % 2 == 1)
                        {
                            Console.Write(ARRAY_FIGURE_2.PadLeft(4));
                        }
                        else
                        {
                            Console.Write(ARRAY_FIGURE_1.PadLeft(4));
                        }
                    }

                    Console.WriteLine("#");
                }

                Console.WriteLine(horizontalBorder);
            }
            else
            {
                Console.WriteLine("Invalid input. Please restart and enter 1 or 2.");
            }
        }
    }
}