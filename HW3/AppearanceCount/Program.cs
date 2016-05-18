using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            decimal[] arrayOfNumber = Console.ReadLine().Split(' ').Select(s => decimal.Parse(s)).ToArray();
            decimal searchedNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine(AppearanceCountInArray(arrayOfNumber, searchedNumber));

        }

        static int AppearanceCountInArray(decimal[] arrayOfNumbers, decimal searchedNumber)
        {
            int counter = 0;

            foreach (var number in arrayOfNumbers)
            {
                if (number == searchedNumber)
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
