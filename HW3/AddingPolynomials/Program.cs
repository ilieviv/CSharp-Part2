using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] first = Console.ReadLine().Split(' ');
            int[] firstPolynomial = new int[n];
            string[] second = Console.ReadLine().Split(' ');
            int[] secondPolynomial = new int[n];

            for (int i = 0; i < n; i++)
            {
                firstPolynomial[i] = int.Parse(first[i]);
                secondPolynomial[i] = int.Parse(second[i]);
            }
            Console.WriteLine(String.Join(" ", AddPolynomials(firstPolynomial, secondPolynomial)));
        }

        static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] result = new int[firstPolynomial.Length];
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            }
            return result;
        }
    }
}
