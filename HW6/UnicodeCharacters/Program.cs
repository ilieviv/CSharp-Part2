using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(UnicodeRepresentation(input));
        }

        private static string UnicodeRepresentation(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                result.Append("\\u" + ((int)c).ToString("X").PadLeft(4, '0'));
            }

            return result.ToString();
        }

    }
}
