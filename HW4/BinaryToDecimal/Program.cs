using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            BigInteger result = 0;

            for (int i = 0; i < num.Length; i++)
            {
                result += (BigInteger)Math.Pow(2, i) * int.Parse(num[num.Length - 1 - i].ToString());
            }

            Console.WriteLine(result.ToString());
        }
    }
}
