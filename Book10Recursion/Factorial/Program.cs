using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var newIn = input.Trim('@ ');
            Console.WriteLine(newIn);
            var n = int.Parse(newIn);
 

            int result = Factorial(n);
            Console.WriteLine(result);
        }
    }
}
