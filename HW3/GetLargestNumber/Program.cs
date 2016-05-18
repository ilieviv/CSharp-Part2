using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine(GetMax(input[0], GetMax(input[1], input[2])));
        }

        static int GetMax(int a, int b)
        {
            int maxNumber = Math.Max(a, b);
            return maxNumber;
        }
    }
}
