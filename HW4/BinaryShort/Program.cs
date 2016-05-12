using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            short num = short.Parse(Console.ReadLine());

            string result = "";
            string[] binKey = "0 1".Split(' ');

            for (int i = 0; i < 16; i++)
            {
                result = binKey[(num & 1)] + result;
                num >>= 1;
            }

            Console.WriteLine(result.PadLeft(16, '0'));
        }
    }
}
