using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class Program
    {
        static int[] ReversedNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            string[] numbers = Console.ReadLine().Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }
            Console.WriteLine(string.Join(" ", ReversedNumbers(array)));
        }
    }
}
