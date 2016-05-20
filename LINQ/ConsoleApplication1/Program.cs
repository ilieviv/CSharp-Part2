using System;
using System.Collections.Generic;
 

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();

          

            

             

            SortedSet<int> list = new SortedSet<int>();
            list.Add(2);
            list.Add(1);
            list.Add(2222);
            list.Add(4);

            foreach (var num in list)
            {
                Console.WriteLine(num);
            }

        }

    }
}
