using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "sun", "mon", "tue", "wed", "thu", "fri", "is", "color", "day", "Saturday" };
            string[] color = new string[] { "Red", "Yellow", "pink", "Green", "Orange", "Bule", "Purple" };
            Console.Write("Input day name :");
            string day = Console.ReadLine();
            switch (day)
            {
                case "sun"://sun is Sunday, color Red
                    int i = 0;
                    Console.WriteLine("{0} {1} {2}{3}, {4} {5}", array[i], array[6], array[i], array[8], array[7], color[i]);
                    break;

                case "mon":
                    i = 1;
                    Console.WriteLine("{0} {1} {2}{3}, {4} {5}", array[i], array[6], array[i], array[8], array[7], color[i]);
                    break;

                case "tue":
                    i = 2;
                    Console.WriteLine("{0} {1} {2}{3}, {4} {5}", array[i], array[6], array[i], array[8], array[7], color[i]);
                    break;

                case "wed":
                    i = 3;
                    Console.WriteLine("{0} {1} {2}{3}, {4} {5}", array[i], array[6], array[i], array[8], array[7], color[i]);
                    break;

                case "thu":
                    i = 4;
                    Console.WriteLine("{0} {1} {2}{3}, {4} {5}", array[i], array[6], array[i], array[8], array[7], color[i]);
                    break;

                case "fri":
                    i = 5;
                    Console.WriteLine("{0} {1} {2}{3}, {4} {5}", array[i], array[6], array[i], array[8], array[7], color[i]);
                    break;
                case "sat":
                    i = 9;
                    Console.WriteLine("{0} {1} {2}{3}, {4} {5}", array[i], array[6], array[i], array[8], array[7], color[6]);
                    break;
            }
            Console.ReadKey();
        }
    }
}
