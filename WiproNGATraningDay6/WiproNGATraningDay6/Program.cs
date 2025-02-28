using System;

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

            // Attempting division
            int result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution completed. Thank you for using the program.");
        }
    }
}
