using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = DivideNumbers(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter valid numbers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }

    private static int DivideNumbers(int a, int b)
    {
        return a / b;  // Might throw DivideByZeroException
    }
}
