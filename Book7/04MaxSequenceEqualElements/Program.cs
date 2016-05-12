using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MaxSequenceEqualElements
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

            int temp = array[0];
            int tempLength = 1;
            int max = 0;
            int element = new int();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == temp)
                {
                    tempLength++;
                }
                else
                {
                    if (tempLength > max)
                    {
                        element = array[i - 1];
                        max = tempLength;
                    }
                    tempLength = 1;
                }

            }

            for (int i = 0; i < max; i++)
            {
                Console.Write("{0}, ", element);
            }
        }
    }
}
