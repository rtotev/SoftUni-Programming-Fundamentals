using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>();
            foreach (string str in input)
            {                
                numbers.Add(int.Parse(str));
            }
            List<int> square = new List<int>();
            foreach (int num in numbers)
            {
                double isSquare = Math.Sqrt(num);               
                if (isSquare == (int)isSquare)
                {
                    square.Add(num);
                }
            }
            square.Sort();
            square.Reverse();
            Console.WriteLine(string.Join(" ", square));
        }
    }
}
