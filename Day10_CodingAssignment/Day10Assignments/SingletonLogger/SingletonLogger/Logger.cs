using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLogger
{
    public class Logger
    {
        private static Logger _logger;

        private Logger() { }
        public static Logger logger {
            get
            {
                if (_logger == null)
                {
                    _logger = new Logger();
                }
                return _logger;
            }
        }
    }
    public class InstanceCheck {
        static void main(string[] args)
        {
            Logger firstinstance = Logger.logger;
            Logger secondinstance = Logger.logger;
            if (firstinstance == secondinstance)
            {
                Console.WriteLine("Both are same instances");
            }
            else
            {
                Console.WriteLine("Both are not same instances");
            }
        }
    }
}
