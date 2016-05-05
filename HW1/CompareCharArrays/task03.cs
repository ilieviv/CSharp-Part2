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
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int compare = first.CompareTo(second);

            if (compare == -1)
            {
                Console.WriteLine("<");
            }
            else if (compare == 1)
            {
                Console.WriteLine(">");
            }
            else if (compare == 0)
            {
                Console.WriteLine("=");
            }
        }
    }
}
