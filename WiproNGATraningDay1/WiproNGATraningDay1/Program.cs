internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string name = "Wipro's";
        string traning = "Great Learning";

        Console.WriteLine(name + " traning partner " + traning);
        Console.WriteLine("Enter the traning name:");

        string inname = Console.ReadLine();
        Console.WriteLine(inname);
        Console.WriteLine($"GL is the traning partner for {name}");
        Console.WriteLine("Enter your coding level:");

        int level = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(level);
        int? a = null; //making a int value a nullable value
        int b = a ?? 10; //null coleasing 
        Console.WriteLine(a);
        Console.WriteLine(b);


        string input = "123";
        int res;

        bool isParse = int.TryParse(input, out res);

        if (isParse)
        {
            Console.WriteLine(res);
        }
        else
        {
            Console.WriteLine("Pares Failed");
        }

        Calculator();

        void Calculator()
        {
            int a = 1;
            int b = 2;
            int sum = a + b;
            int multiply = a * b;
            Console.WriteLine(multiply);
            Console.WriteLine(sum);
        }

        int max = int.MaxValue;
        int min = int.MinValue;

        Console.WriteLine("The max value is: " + max);
        Console.WriteLine("The min value is :" + min);


        //Employe emp1 = new Employe("John", 3);

    }

    public class Employe
    {
        private string name;
        private int exp;

        public Employe(string name, int exp)
        {
            this.name = name;

            this.exp = exp;

            Console.WriteLine("Employe " + name + " has " + exp + " year's exp.");

        }
    }
}