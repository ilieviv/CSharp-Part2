using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(num));
        }

        static BigInteger CalculateFactorial(int num)
        {
            BigInteger result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
