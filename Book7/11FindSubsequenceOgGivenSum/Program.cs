using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11FindSubsequenceOgGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[] { 4, 3, 1, 4, 2, 5, 8 };
            int sum = 13;

            FindSequenceOfGivenSum(numbersArray, sum);

        }

        static void PrintArray(int startIndex, int endIndex, int[] array)
        {
            Console.WriteLine("Sequence of given sum is present:");
            Console.Write("{ ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write("}");
        }

        private static void FindSequenceOfGivenSum(int[] numbersArray, int sum)
        {
            long currentSum = 0;
            for (int currentEndIndex = 0; currentEndIndex < numbersArray.Length; currentEndIndex++)
            {
                currentSum = 0;
                for (int currentSumIndex = currentEndIndex; currentSumIndex >= 0; currentSumIndex--)
                {
                    currentSum += numbersArray[currentSumIndex];
                    if (currentSum == sum)
                    {
                        PrintArray(currentSumIndex, currentEndIndex, numbersArray);
                        return;
                    }
                }
            }
            Console.WriteLine("There is no sequence of given sum!");
        }
    }
}
 
