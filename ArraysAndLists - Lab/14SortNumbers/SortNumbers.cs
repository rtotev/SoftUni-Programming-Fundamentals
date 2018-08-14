using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<double> numbers = new List<double>();
            foreach (string num in input)
            {
                numbers.Add(double.Parse(num));
            }
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
