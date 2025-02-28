using System;

namespace AccessModifiersReferenceNullable
{
    // Access Modifiers Example
    public class Person  // Public class (accessible everywhere)
    {
        private string name;  // Private field (accessible only within the class)

        protected int age;  // Protected field (accessible in derived classes)

        internal string address;  // Internal field (accessible within the same assembly)

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void Display()  // Public method (accessible anywhere)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
        }
    }

    // Reference Type Example (Class)
    public class Employee : Person
    {
        public string? Department { get; set; }  // Nullable reference type

        public Employee(string name, int age, string address, string? department)
            : base(name, age, address)
        {
            Department = department;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Department: {Department ?? "No department assigned"}");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Access Modifiers, Reference Types & Nullable Types Example\n");

            // Creating an instance of Employee (Reference Type)
            Employee emp1 = new Employee("Alice", 30, "123 Main St", "HR");
            emp1.Display();
            emp1.ShowDetails();

            // Nullable Type Example
            int? nullableInt = null;  // Nullable value type
            Console.WriteLine($"Nullable Integer: {nullableInt?.ToString() ?? "Null"}");

            Employee emp2 = new Employee("Bob", 25, "456 Elm St", null);
            emp2.Display();
            emp2.ShowDetails();  // Handles nullable Department property safely

            // Reference Type Behavior
            Employee emp3 = emp1; // emp3 and emp1 refer to the same object
            emp3.Department = "Finance";

            Console.WriteLine("\nAfter modifying emp3:");
            emp1.ShowDetails();  // The change reflects in emp1 as well (reference type behavior)
        }
    }
}
