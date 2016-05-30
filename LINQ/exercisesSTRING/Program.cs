using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercisesSTRING
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Gosho");
            builder.Insert(0, "Iva");
            builder.Replace('o', 'r')
            Console.WriteLine(builder.ToString());
        }
    }
}
