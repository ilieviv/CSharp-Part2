using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindWordInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../test.txt";
            StreamReader reader = new StreamReader(path);

            int count = 0;
            string text = reader.ReadToEnd();

            int index = text.IndexOf("Alien", 0);

            while (index != -1)
            {
                count++;
                index = text.IndexOf("Alien", index + 1);
            }
            Console.WriteLine(count);

        }
    }
}
