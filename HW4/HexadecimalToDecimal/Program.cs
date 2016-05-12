using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine().ToUpper();

            string[] hexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            BigInteger result = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                result += (BigInteger)Math.Pow(16, i) * Array.IndexOf(hexKey, hex[hex.Length - 1 - i].ToString());
            }
            Console.WriteLine(result);
        }
    }
}
