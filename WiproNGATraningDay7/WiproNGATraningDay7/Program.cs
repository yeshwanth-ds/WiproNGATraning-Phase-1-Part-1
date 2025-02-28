using System;

delegate void PrintMessage(string message);  // Delegate declaration

internal class Program
{
    private static void Main(string[] args)
    {
        PrintMessage print = DisplayMessage;  // Assign method to delegate
        print("Hello, this is a basic delegate example!");  // Invoke delegate
    }

    static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}
