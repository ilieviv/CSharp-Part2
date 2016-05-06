using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MaximalSum
{
    class task08
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            BitArray sumFlags = new BitArray(n);
            BitArray maxFlags = new BitArray(n);

            int currentSum = 0;
            int maxSum = array.Sum();

            for (int curNumb = 0; curNumb < array.Length; curNumb++)
            {
                currentSum += array[curNumb];
                sumFlags.Set(curNumb, true);

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;

                    maxFlags.SetAll(false);
                    maxFlags.Or(sumFlags);
                }
                else
                {
                    if (currentSum < 0)
                    {
                        currentSum = 0;
                        sumFlags.SetAll(false);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
