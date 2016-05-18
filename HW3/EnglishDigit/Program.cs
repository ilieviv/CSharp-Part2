using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetWord(input));
        }

        static string GetWord(int num)
        {
            int lastNumber = num % 10;
            string digitAsWord = null;

            switch (lastNumber)
            {
                case 1: digitAsWord = "one"; break;
                case 2: digitAsWord = "two"; break;
                case 3: digitAsWord = "three"; break;
                case 4: digitAsWord = "four"; break;
                case 5: digitAsWord = "five"; break;
                case 6: digitAsWord = "six"; break;
                case 7: digitAsWord = "seven"; break;
                case 8: digitAsWord = "eight"; break;
                case 9: digitAsWord = "nine"; break;
                case 0: digitAsWord = "zero"; break;
                default: throw new ArgumentException("You must enter a valid integer!");
            }
            return digitAsWord;
        }
    }
}
