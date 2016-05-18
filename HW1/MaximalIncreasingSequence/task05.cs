using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
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

            int count = 1;
            int maxLength = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    count++;
                    maxLength = Math.Max(maxLength, count);
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxLength);
        }
    }
}
