using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09maxSequenceSum
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

            int currentSum = 0;
            int maxSum = 0;

            for (int i = 0; i < n; i++)
            {
                currentSum = currentSum + array[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < maxSum)
                {
                    currentSum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
