﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            object o2 = null;
            
            try
            {
                int i2 = (int)o2;
                Console.WriteLine("i2 = {0}", i2);
            }
            catch
            {
                Console.WriteLine("Error, null obej assignment");
            }
        }
    }
}
