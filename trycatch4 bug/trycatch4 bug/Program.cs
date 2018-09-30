using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch4_bug
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            a *= 2;
            Console.WriteLine(a);

        }
    }
}
