﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }
            Console.WriteLine(Minimum(numbers));
            Console.WriteLine(Maximum(numbers));
            Console.WriteLine("{0:F2}", Average(numbers));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Product(numbers));
        }

        static int Minimum(int[] numbers)
        {
            return numbers.Min();
        }

        static int Maximum(int[] numbers)
        {
            return numbers.Max();
        }

        static double Average(int[] numbers)
        {
            return numbers.Average();
        }

        static int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        static BigInteger Product(int[] numbers)
        {
            BigInteger prod = 1;

            foreach (var number in numbers)
            {
                prod *= number;
            }
            return prod;
        }

    }
}
