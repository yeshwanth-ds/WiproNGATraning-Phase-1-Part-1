using System;

internal class Program
{
    // Instance method (Requires an object to call)
    public void InstanceMethod()
    {
        Console.WriteLine("This is an instance method.");
    }

    // Static method (Can be called without creating an object)
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }

    // Parameterless method
    public void ParameterlessMethod()
    {
        Console.WriteLine("This method has no parameters.");
    }

    // Method with parameters
    public void MethodWithParameters(string name, int age)
    {
        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }

    // Method with return type
    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // Method overloading (same method name, different parameters)
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    // Recursive method (calls itself)
    public int Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }

    private static void Main(string[] args)
    {
        // Creating an instance of the Program class
        Program obj = new Program();

        // Calling instance method
        obj.InstanceMethod();

        // Calling static method
        StaticMethod();

        // Calling parameterless method
        obj.ParameterlessMethod();

        // Calling method with parameters
        obj.MethodWithParameters("Alice", 25);

        // Calling method with return type
        int sum = obj.AddNumbers(10, 5);
        Console.WriteLine($"Sum: {sum}");

        // Calling overloaded method
        int product1 = obj.Multiply(3, 4);
        double product2 = obj.Multiply(2.5, 4.2);
        Console.WriteLine($"Integer Multiplication: {product1}");
        Console.WriteLine($"Double Multiplication: {product2}");

        // Calling recursive method
        int fact = obj.Factorial(5);
        Console.WriteLine($"Factorial of 5: {fact}");
    }
}
