using System;
using System.Collections.Generic;

internal class Program
{
    // Generic Method
    public static void Print<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
    }

    // Generic Class
    public class Box<T>
    {
        private T item;

        public void Add(T newItem)
        {
            item = newItem;
        }

        public T GetItem()
        {
            return item;
        }
    }

    // Generic Interface
    public interface IStorage<T>
    {
        void Store(T item);
        T Retrieve();
    }

    // Implementing Generic Interface
    public class Storage<T> : IStorage<T>
    {
        private T storedItem;

        public void Store(T item)
        {
            storedItem = item;
        }

        public T Retrieve()
        {
            return storedItem;
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Generics Example in C#");

        // Using Generic Method
        Print(10);
        Print("Hello, Generics!");
        Print(3.14);

        // Using Generic Class
        Box<int> intBox = new Box<int>();
        intBox.Add(100);
        Console.WriteLine($"Box contains: {intBox.GetItem()}");

        Box<string> stringBox = new Box<string>();
        stringBox.Add("Generic Class Example");
        Console.WriteLine($"Box contains: {stringBox.GetItem()}");

        // Using Generic Interface
        IStorage<double> storage = new Storage<double>();
        storage.Store(99.99);
        Console.WriteLine($"Stored value: {storage.Retrieve()}");

        // Using Generic Collection (List<T>)
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        Console.WriteLine("Generic List:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
