﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            char[] a = new char[m];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = char.Parse(Console.ReadLine());

            }

            int n = int.Parse(Console.ReadLine());
            char[] b = new char[n];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = char.Parse(Console.ReadLine());
            }

            int shorter, longer;

            if (m - n > 0)
            {
                shorter = n;
                longer = m;
            }
            else if (n - m > 0)
            {
                shorter = m;
                longer = n;
            }
            else
            {
                shorter = m;
                for (int i = 0; i < m; i++)
                {
                    if (a[i] == b[i])
                    {
                        continue;
                    }
                    else if(a[i] > b[i])
                    {
                        Console.WriteLine("Array B");
                        return;
                    }
                    else if (a[i] < b[i])
                    {
                        Console.WriteLine("Array A");
                        return;
                    }
                }
                Console.WriteLine("None");
                return;
            }
            bool equal = true;
            while (equal)
            {
                for (int i = 0; i < shorter; i++)
                {
                    if (a[i] < b[i])
                    {
                        Console.WriteLine("Array A");
                        return;
                    }
                    else if (a[i] > b[i])
                    {
                        Console.WriteLine("Array B");
                        return;
                    }
                }
                equal = false;
            }
            if (shorter == n)
            {
                Console.WriteLine("Array B");
            }
            else
            {
                Console.WriteLine("Array A");
            }

        }
    }
}
