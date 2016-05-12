using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();

            string hex = "";
            string[] hexKey = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

            string currentBinSection = "";
            int currentHexIndex = 0;

            while (bin.Length > 0)
            {
                if (bin.Length >= 4)
                {
                    currentBinSection = bin.Substring(bin.Length - 4, 4);
                    bin = bin.Remove(bin.Length - 4, 4);
                }
                else
                {
                    currentBinSection = bin;
                    bin = "";
                }

                currentHexIndex = 0;

                for (int i = 0; i < currentBinSection.Length; i++)
                {
                    currentHexIndex += (int)Math.Pow(2, i) * int.Parse(currentBinSection[currentBinSection.Length - 1 - i].ToString());
                }

                hex = hexKey[currentHexIndex] + hex;
            }

            Console.WriteLine(hex);

        }
    }
}
