public static void DisplayWelcomeMessage()
{
    Console.WriteLine("Welcome to playing tictactoe against AI!")
}

public static bool MakeDecision()
{
    Console.WriteLine("Do you want to play?");
    if (Console.ReadLine() == "yes")
    {
        return true;
    }
    else
    {
        return false;
    }
}