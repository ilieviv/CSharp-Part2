using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> reverse = new List<char>();
            
            foreach (char letter in input)
            {
                reverse.Add(letter);
            }

            reverse.Reverse();

            foreach (char let in reverse)
            {
                Console.Write(let);
            }
        }
    }
}
