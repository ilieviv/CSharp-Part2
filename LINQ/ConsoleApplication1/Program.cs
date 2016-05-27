using System;
using System.Collections.Generic;
using System.Linq;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            dict["SomeString"] = 5;

            var result = dict.Where(x => x.Value > 2);
        }

    }
}
