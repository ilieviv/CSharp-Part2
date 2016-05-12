using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            string result = "";

            while (num > 0)
            {
                result = (num % 2).ToString() + result;
                num /= 2;
            }
            Console.WriteLine(result);
        }
    }
}
