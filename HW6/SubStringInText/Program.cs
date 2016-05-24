using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            var find = Console.ReadLine().ToLower();
            var search = Console.ReadLine().ToLower();
            var currentIndex = search.IndexOf(find);
            var counter = 0;

            while (currentIndex >= 0)
            {
                counter++;

                currentIndex = search.IndexOf(find, ++currentIndex);
            }

            Console.WriteLine(counter);
        }
    }
}
