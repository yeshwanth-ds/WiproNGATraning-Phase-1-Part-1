using System;

delegate void Operation(int a, int b);

internal class Program
{
    private static void Main(string[] args)
    {
        PerformOperation(5, 3, Add);
        PerformOperation(5, 3, Multiply);
    }

    static void PerformOperation(int x, int y, Operation op)
    {
        op(x, y);
    }

    static void Add(int x, int y)
    {
        Console.WriteLine("Addition: " + (x + y));
    }

    static void Multiply(int x, int y)
    {
        Console.WriteLine("Multiplication: " + (x * y));
    }
}
