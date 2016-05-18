using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class task06
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 0; i < k; i++)
            {
                sum = sum + array[i];
            }

            Console.WriteLine(sum);

        }
    }
}
