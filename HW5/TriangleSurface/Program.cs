using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double alt = double.Parse(Console.ReadLine());

            double result = (side * alt) / 2;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
