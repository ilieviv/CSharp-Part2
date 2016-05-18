using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseNumber(input));
        }

        static decimal ReverseNumber(string number)
        {
            string reversedNumber = null;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }
            return decimal.Parse(reversedNumber);
        }
    }
}
