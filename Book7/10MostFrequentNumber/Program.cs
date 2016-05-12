using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10MostFrequentNumber
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
            int maxCount = 1;
            int maxNumber = array[0];

            Array.Sort(array);

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == array[i])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxNumber = array[i - 1];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxNumber + " - " + maxCount + " times");
        }
    }
}
