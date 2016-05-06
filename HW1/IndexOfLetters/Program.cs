using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char current;

            char[] letters = new char[26];
            int index = 0;

            for (char i = 'a'; i <= 'z'; i++, index++)
            {
                letters[index] = i;
            }

            for (int i = 0; i < word.Length; i++)
            {
                current = word[i];
                Console.WriteLine(Array.IndexOf(letters, current));
            }
        }
    }
}
