using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01Rebuild
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string operation = Console.ReadLine();
            string second = Console.ReadLine();
            BigInteger sum = 0;
            string result = "";

            BigInteger resultFirst = 0;
            foreach (char digit in first)
            {
                resultFirst = (digit - 'a') + resultFirst * 26;
            }

            BigInteger resultSecond = 0;
            for (int i = 0; i < second.Length; i++)
            {
                resultSecond += BigInteger.Pow(7, i) * BigInteger.Parse(second[second.Length - 1 - i].ToString());
            }

            if (operation == "+")
            {
                sum = resultFirst + resultSecond;
            }
            else if (operation == "-")
            {
                sum = resultFirst - resultSecond;
            }

            while (sum > 0)
            {
                result = (sum % 9).ToString() + result;
                sum /= 9;
            }
            Console.WriteLine(result);

        }
    }
}
