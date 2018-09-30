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
            Console.WriteLine("Line1");
            Console.WriteLine("Linw2");
            Console.WriteLine("line3");
            line4:
            Console.WriteLine("Line4");
            Console.WriteLine("Line5");
            Console.WriteLine("Line6");
            goto line10;
            Console.WriteLine("Line7");
            Console.WriteLine("Line8");
            Console.WriteLine("Line9");
            line10:
            Console.WriteLine("Line10");

        }
    }
}
