using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            var open = "upcase";
            var close = "/upcase";

            var parse = Console
                .ReadLine()
                .Split(new char[] { '<', '>' })
                .ToArray();

            var output = new StringBuilder();
            var toUpper = false;

            foreach (var word in parse)
            {
                if (word == open)
                {
                    toUpper = true;
                    continue;
                }

                if (word == close)
                {
                    toUpper = false;
                    continue;
                }

                if (toUpper)
                {
                    output.Append(word.ToUpper());
                }
                else
                {
                    output.Append(word);
                }
            }

            Console.WriteLine(output);
        }
    }
}
