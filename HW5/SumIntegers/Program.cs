using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = input
                .Trim(' ')
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                .Sum();

            Console.WriteLine(sum);
        }
    }
}
