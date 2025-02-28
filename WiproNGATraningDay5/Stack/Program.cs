using System;
using System.Collections.Generic; // Required for Stack<T>

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating a Stack of integers
        Stack<int> stack = new Stack<int>();

        // Push (Add elements to the stack)
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        // Displaying elements in the stack
        Console.WriteLine("Elements in the stack:");
        foreach (int num in stack)
        {
            Console.WriteLine(num);
        }

        // Pop (Remove the top element)
        int removedItem = stack.Pop();
        Console.WriteLine($"\nPopped item: {removedItem}");

        // Peek (Check the top element without removing it)
        int topItem = stack.Peek();
        Console.WriteLine($"Top item after pop: {topItem}");

        // Checking if an element exists
        Console.WriteLine(stack.Contains(20) ? "20 is in the stack." : "20 is not in the stack.");

        // Getting count of elements
        Console.WriteLine($"Number of elements in stack: {stack.Count}");

        // Clearing the stack
        stack.Clear();
        Console.WriteLine($"Stack cleared. Current count: {stack.Count}");
    }
}
