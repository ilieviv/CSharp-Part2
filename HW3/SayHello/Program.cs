﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, {0}!", Name());
        }

        public static string Name()
        {
            return Console.ReadLine();
        }
    }
}
