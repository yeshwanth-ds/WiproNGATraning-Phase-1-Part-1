using System;

delegate int MathOperation(int a, int b);

internal class Program
{
    private static void Main(string[] args)
    {
        MathOperation add = Add;
        MathOperation multiply = Multiply;

        Console.WriteLine("Addition: " + add(5, 3));
        Console.WriteLine("Multiplication: " + multiply(5, 3));
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }
}
