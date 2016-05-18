using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceTwoSIdesAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double angle = Math.PI * d / 180;

            double result = (a * b * Math.Sin(angle)) / 2;
            Console.WriteLine(result.ToString("f2"));
        }
    }
}
