using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbersList = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            Console.WriteLine(FirstLarger(numbersList));
        }

        static int FirstLarger(List<int> numbersList)
        {
            for (int i = 1; i < numbersList.Count - 1; i++)
            {
                int currentNumber = numbersList[i];

                if (numbersList[i - 1] < currentNumber && numbersList[i + 1] < currentNumber)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
