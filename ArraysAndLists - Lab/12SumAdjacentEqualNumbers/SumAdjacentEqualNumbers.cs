using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<double> numbers = new List<double>();
            foreach (string str in input)
            {
                numbers.Add(double.Parse(str)); 
            }
            for (int j  = 0; j < numbers.Count; j++)
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        if (numbers[i] == numbers[i + 1])
                        {
                            numbers[i] = numbers[i] + numbers[i + 1];
                            numbers.RemoveAt(i+1);                
                        }
                    }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
