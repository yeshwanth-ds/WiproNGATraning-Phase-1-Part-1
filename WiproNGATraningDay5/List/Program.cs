using System;
using System.Collections.Generic; // Required for List<T>

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating a list of integers
        List<int> numbers = new List<int>();

        // Adding elements to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);

        // Displaying elements
        Console.WriteLine("Elements in the list:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Inserting an element at a specific position
        numbers.Insert(2, 25); // Insert 25 at index 2

        // Removing an element
        numbers.Remove(10); // Removes the first occurrence of 10

        // Checking if an element exists
        if (numbers.Contains(30))
        {
            Console.WriteLine("30 is in the list.");
        }

        // Finding index of an element
        int index = numbers.IndexOf(40);
        Console.WriteLine("Index of 40: " + index);

        // Sorting the list
        numbers.Sort();

        // Displaying sorted list
        Console.WriteLine("Sorted List:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Clearing the list
        numbers.Clear();
        Console.WriteLine("List cleared. Count: " + numbers.Count);
    }
}
