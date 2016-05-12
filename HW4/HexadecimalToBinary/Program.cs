using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            string[] hexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            string binary = "";
            string tempBinary = "";

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                var curDigit = Array.IndexOf(hexKey, hex[i].ToString());

                while (curDigit > 0)
                {
                    tempBinary = (curDigit % 2).ToString() + tempBinary;

                    curDigit /= 2;
                }

                tempBinary = tempBinary.PadLeft(4, '0');

                binary = tempBinary + binary;

                tempBinary = "";
            }

            // Print
            Console.WriteLine(binary.TrimStart('0'));
        }
    }
}
