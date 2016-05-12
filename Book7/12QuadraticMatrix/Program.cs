using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12QuadraticMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int N = int.Parse(str);
            int[,] arrNN = new int[N, N];

            int k = 0;
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    arrNN[j, i] = i + j + k + 1;
                }
                k += N - 1;
            }

            for (int i = 0; i < arrNN.GetLength(0); i++)
            {
                for (int j = 0; j < arrNN.GetLength(1); j++)
                {
                    Console.Write("{0}", arrNN[i, j].ToString().PadRight((N * N).ToString().Length + 1));
                }
                if (i != arrNN.GetLength(0))
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
