using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger  firstinstance=Logger.logger;
            Logger secondinstance=Logger.logger;
            if (firstinstance == secondinstance)
            {
                Console.WriteLine("Both are same instances");
            }
            else {
                Console.WriteLine("Different Instances");
            }
        }
    }
}
