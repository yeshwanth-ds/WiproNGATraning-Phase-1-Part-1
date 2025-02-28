using System;
using System.Collections; // Required for Hashtable

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating a Hashtable
        Hashtable hashtable = new Hashtable();

        // Adding key/value pairs to the Hashtable
        hashtable.Add("Name", "John");
        hashtable.Add("Age", 30);
        hashtable.Add("Occupation", "Software Developer");
        hashtable.Add("Country", "USA");

        // Displaying the elements in the Hashtable
        Console.WriteLine("Hashtable elements:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // Accessing a value using a key
        Console.WriteLine("\nAccessing a value by key:");
        string name = (string)hashtable["Name"];
        Console.WriteLine($"Name: {name}");

        // Checking if a key exists
        Console.WriteLine("\nChecking if 'Age' exists in Hashtable:");
        if (hashtable.ContainsKey("Age"))
        {
            Console.WriteLine("Key 'Age' exists.");
        }

        // Removing a key/value pair
        hashtable.Remove("Country");
        Console.WriteLine("\n'Country' key removed.");

        // Checking if a key exists after removal
        if (!hashtable.ContainsKey("Country"))
        {
            Console.WriteLine("Key 'Country' no longer exists.");
        }

        // Getting the count of elements in the Hashtable
        Console.WriteLine($"\nNumber of elements in Hashtable: {hashtable.Count}");

        // Clearing the Hashtable
        hashtable.Clear();
        Console.WriteLine($"Hashtable cleared. Current count: {hashtable.Count}");
    }
}
