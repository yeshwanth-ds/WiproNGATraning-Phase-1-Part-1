using System;
using System.Threading;

internal class Program
{
    // Method to be executed on a separate thread
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(1000); // Simulating work by pausing for 1 second
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Main thread started.");

        // Creating a new thread
        Thread thread = new Thread(PrintNumbers);
        thread.Start(); // Start the new thread

        // Main thread continues executing
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Main thread: {i}");
            Thread.Sleep(1000);
        }

        thread.Join(); // Wait for the new thread to complete
        Console.WriteLine("Main thread finished.");
    }
}
