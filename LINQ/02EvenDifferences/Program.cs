using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EvenDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long sum = 0;
            int i = 1;

            while (i < input.Length)
            {
                long absDiff = Math.Abs(input[i] - input[i - 1]);

                if (absDiff % 2 == 0)
                {
                    sum += absDiff;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
