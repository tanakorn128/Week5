using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,count;
            x = 200;
            y = 4;
            count = 0;
            string[,] array = new string[x, y];

            //Initialize the array;
            for (int i =0; i<x;  i++)
                for (int j=0; j <y; j++)
                    array[i, j] = (++count).ToString();

                //Read input:
                Console.Write("Enter the number to search for:");

                //Input string
                string myNumber = Console.ReadLine();
                //Search
               for(int i = 0;i<x;i++)
            {
                for(int j = 0; j<y;j++)
                {
                    if (array[i, j].Equals(myNumber)) ;
                    {
                        goto Found;
                    }
                }
            }
            Console.WriteLine("The number {0} was not found.",myNumber);
            goto Finish;
            Found:
            Console.WriteLine("The number {0} is found",myNumber);
            Finish:
            Console.WriteLine("End of search.");

            //Keep the console open debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
