using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParseUrl
{
    class Program
    {
        static void Main(string[] args)
        {
            var format = new string[]
            {
                "[protocol] = {0}",
                "[server] = {0}",
                "[resource] = /{0}"
            };

            var parse = Console.ReadLine();

            var URLPattern = (@"(\w*)://(.*)/(.*)");

            var Match = Regex.Match(parse, URLPattern, RegexOptions.RightToLeft);

            var toPrint = new List<object>();

            foreach (var group in Match.Groups)
            {
                if (group.ToString() != parse)
                {
                    toPrint.Add(group);
                }
            }

            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine(string.Format(format[index], toPrint[index]));
            }

        }
    }
}
