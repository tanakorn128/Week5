using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycat4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10;
            try
            {
                b /= a;
                Console.WriteLine(a);
            }
        catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
