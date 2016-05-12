﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int toFindK = int.Parse(Console.ReadLine());

            int arraySize = int.Parse(Console.ReadLine());

            int[] toSearch = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                toSearch[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(toSearch);

            int SearchResult = Array.BinarySearch(toSearch, toFindK);
            // -1 -> ToFindK is smallest,  
            // less than -1 -> next largest element in the array
            // Negative number complement ( ~ ) of index
            // positive -> the index of the element found.


            if (SearchResult == -1)
            {
                Console.WriteLine("No result!\n" + Environment.NewLine +
                        "{0} is the smallest element", toFindK);
            }
            else if (SearchResult < -1)
            {
                Console.WriteLine("Largest element < {0}:" + Environment.NewLine +
                        "value: {1}, position: [{2}]",
                         toFindK, toSearch[(~SearchResult) - 1], (~SearchResult) - 1);
            }
            else
            {
                Console.WriteLine("Exact Match:" + Environment.NewLine +
                        "value: {0}, position: [{1}]", toFindK, SearchResult);
            }
    }
}
