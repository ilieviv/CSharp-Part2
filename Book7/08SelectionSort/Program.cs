using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            //The second way is from the exercise!!!



            //int min;
            //for (int i = 0; i < n; i++)
            //{
            //    min = i;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (numbers[j] < numbers[min])
            //        {
            //            min = j;
            //        }
            //    }
            //    int temp = numbers[i];
            //    numbers[i] = numbers[min];
            //    numbers[min] = temp;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    if (i != n - 1)
            //    {
            //        Console.Write("{0} ", numbers[i]);
            //    }
            //    else
            //    {
            //        Console.Write(numbers[i]);
            //    }

            //}
           
        }
    }
}
