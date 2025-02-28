using System;

namespace MethodOverloadingExample
{
    internal class Program
    {
        // Method to add two integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded method to add two doubles
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Overloaded method to add an integer and a double
        public static double Add(int a, double b)
        {
            return a + b;
        }

        // Main method
        private static void Main(string[] args)
        {
            // Using the Add method with two integers
            Console.WriteLine($"Sum of 10 and 20: {Add(10, 20)}");

            // Using the Add method with three integers
            Console.WriteLine($"Sum of 10, 20, and 30: {Add(10, 20, 30)}");

            // Using the Add method with two doubles
            Console.WriteLine($"Sum of 10.5 and 20.5: {Add(10.5, 20.5)}");

            // Using the Add method with an integer and a double
            Console.WriteLine($"Sum of 10 and 20.5: {Add(10, 20.5)}");
        }
    }
}
