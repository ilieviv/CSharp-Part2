using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MaxSequenceOfAscendingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;


            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    len++;
                    if (len == 2)
                    {
                        start = i - 1;
                    }
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    len = 1;
                }
            }
            Console.WriteLine();
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
