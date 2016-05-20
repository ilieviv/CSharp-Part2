using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char temp = 'z';

            foreach (char ch in input)
            {
                if (temp != ch)
                {
                    Console.Write(ch);
                    temp = ch;
                }
            }
        }
    }
}
