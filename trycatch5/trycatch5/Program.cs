using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 800000000;
            checked// Check for overflow
            {
                try
                {
                    int square = value * value;
                    Console.WriteLine("{0} ^ 2 = {1}", value, square);
                }
                catch(OverflowException a)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
