using System;

delegate void PrintMessage(string message);

internal class Program
{
    private static void Main(string[] args)
    {
        PrintMessage print = FirstMessage;
        print += SecondMessage;  // Adding another method to the delegate

        print("Hello!");  // Both methods will be invoked
    }

    static void FirstMessage(string message)
    {
        Console.WriteLine("First method: " + message);
    }

    static void SecondMessage(string message)
    {
        Console.WriteLine("Second method: " + message);
    }
}
