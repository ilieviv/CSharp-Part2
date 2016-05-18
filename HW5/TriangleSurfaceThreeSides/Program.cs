using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceThreeSides
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double halfPerimeter = (a + b + c) / 2;
            double sqr = halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c); ;
            double area = Math.Sqrt(sqr);

            Console.WriteLine(area.ToString("f2"));

        }
    }
}
