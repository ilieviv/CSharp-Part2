using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19PrimeNumbers_SieveOfErathostens
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10000;
            bool[] flag = new bool[num];

            for (int i = 2; i < num; i++)
            {
                flag[i] = true;
            }

            for (int i = 2; i < num; i++)
            {
                if (flag[i] == true)
                {
                    int j = i + 1;
                    while (j < num)
                    {
                        if (j % i == 0)
                        {
                            flag[j] = false;
                        }
                        j++;
                    }
                }
            }

            for (int i = 2; i < num; i++)
            {
                if (flag[i] == true)
                {
                    Console.Write("{0} ", i);
                }
            }

        }
    }
}
