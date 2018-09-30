using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        line1:
            Console.WriteLine("Line1");
            goto line4;
        line2:
            Console.WriteLine("Linw2");
            goto line9;
            Console.WriteLine("line3");
        line4:
            Console.WriteLine("Line4");
            goto line5;
        line5:
            Console.WriteLine("Line5");
            goto line2;
            Console.WriteLine("Line6");
            Console.WriteLine("Line7");
            Console.WriteLine("Line8");
            line9:
            Console.WriteLine("Line9");
            Console.WriteLine("Line10");

        }
    }
}
