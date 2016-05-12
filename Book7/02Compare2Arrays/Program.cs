using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Compare2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[m];

            for (int i = 0; i < first.Length; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < first.Length; i++)
            {
                second[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(first);
            Array.Sort(second);

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }
    }
}
