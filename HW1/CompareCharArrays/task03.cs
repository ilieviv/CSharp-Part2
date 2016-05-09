using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class task03
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            if (firstWord.Length < secondWord.Length)
            {
                firstWord = firstWord.PadRight(secondWord.Length, (char)(0));
            }
            else if (firstWord.Length > secondWord.Length)
            {
                secondWord = secondWord.PadRight(firstWord.Length, (char)(0));
            }

            char[] arrayA = firstWord.ToCharArray();
            char[] arrayB = secondWord.ToCharArray();

            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] < arrayB[i])
                {
                    Console.WriteLine("<");
                    return;
                }
                else if (arrayA[i] > arrayB[i])
                {
                    Console.WriteLine(">");
                    return;
                }
            }

            Console.WriteLine("=");
        }
    }
}
