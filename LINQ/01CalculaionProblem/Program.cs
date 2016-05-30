using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CalculaionProblem
{
    class Program
    {
        static int MeowToDec(string meow)
        {
            int result = 0;
            foreach (char digit in meow)
            {
                result = (digit - 'a') + result * 23;
            }
            return result;
        }

        static string DecToMeow(int dec)
        {
            var result = string.Empty;
            do
            {
                char digit = (char)('a' + (dec % 23));
                result = digit + result;
                dec /= 23;
            } while (dec > 0);

            return result;
        }

        static void Main(string[] args)
        {
            var sum = Console.ReadLine()
                .Split(' ')
                .Select(MeowToDec)
                .Sum();

            var answer = DecToMeow(sum) + " = " + sum;

            Console.WriteLine(answer);

        }
    }
}
