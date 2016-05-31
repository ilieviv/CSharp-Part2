using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "  111 $ @ Ivan Ivanov %%";

            char[] trimChars = new char[] { ' ', '1', '$', '@', '#', '%'};

            string newtext = text.Trim(trimChars);

            Console.WriteLine(newtext);
             
        }

    }
}
