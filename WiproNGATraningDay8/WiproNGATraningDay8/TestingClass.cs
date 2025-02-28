using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproNGATraningDay8
{
    public class TestingClass
    {
        
        public int Add(int a, int b)
        {
            return a + b;
        }

    
        public int Subtract(int a, int b)
        {
            return a - b;
        }

       
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // Return NaN if division by zero occurs
            }
            return (double)a / b;
        }

        
        public int Modulus(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Modulus by zero is not allowed.");
                return 0;
            }
            return a % b;
        }
    }
}
