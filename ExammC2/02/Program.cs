using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToArray();
            string[] path = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int soul = 0;     //@ 
            int food = 0;     //*
            int deadlock = 0; //x
            int counter = 0;

            if (input[0] == '@')
            {
                soul++;
                input[0] = 'e';
            }
            if (input[0] == '*')
            {
                food++;
                input[0] = 'e';
            }
            if (input[0] == 'x')
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: {0}", counter);
                return;
            }

            int jumps = path.Length;
            int p = 0;

            for (int i = 0; i < jumps; i++)
            {

                int move = int.Parse(path[i]) + p;                  //move =    1     0       -1      10
                if (move < input.Length && move >= 0)
                {
                    p = move;                                       //p =       1     0        6      3   
                }
                else if (move < 0)
                {
                    p = (input.Length + move) % input.Length;
                }
                else if (move >= input.Length)
                {
                    p = move % input.Length;
                }


                if (input[p] == '@')
                {
                    soul++;
                    input[p] = 'e';
                }
                else if (input[p] == '*')
                {
                    food++;
                    input[p] = 'e';
                }
                else if (input[p] == 'x')
                {
                    if (p % 2 == 0)
                    {
                        input[p] = '@';      //added
                        soul--;
                    }
                    else if (p % 2 == 1)
                    {
                        input[p] = '*';      //added
                        food--;
                    }

                    deadlock++;
                }
                counter++;

                if (soul < 0 && food < 0)
                {
                    break;
                }

            }

            if (soul < 0 || food < 0)
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: {0}", counter);
            }
            Console.WriteLine("Coder souls collected: {0}", soul);
            Console.WriteLine("Food collected: {0}", food);
            Console.WriteLine("Deadlocks: {0}", deadlock);

        }
    }
}