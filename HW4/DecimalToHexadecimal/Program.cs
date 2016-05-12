using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            string hex = "";
            string[] hexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            while (num > 0)
            {
                hex = hexKey[(int)(num % 16)] + hex;
                num /= 16;
            }
            Console.WriteLine(hex);
        }
    }
}
