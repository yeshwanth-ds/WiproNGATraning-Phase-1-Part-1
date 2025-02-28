using System;
using System.Reflection;

class SampleClass
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Type type = typeof(SampleClass); // Get type metadata

        Console.WriteLine("Class Name: " + type.Name);

        Console.WriteLine("\nProperties:");
        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name + " - " + prop.PropertyType);
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
        {
            Console.WriteLine(method.Name);
        }
    }
}
