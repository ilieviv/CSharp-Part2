using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int openBracket = 0;
            int closeBracket = 0;

            foreach (var element in input)
            {
                if (element == '(')
                {
                    openBracket++;
                    continue;
                }

                if (element == ')')
                {
                    closeBracket++;
                    continue;
                }
            }

            if (openBracket == closeBracket)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
