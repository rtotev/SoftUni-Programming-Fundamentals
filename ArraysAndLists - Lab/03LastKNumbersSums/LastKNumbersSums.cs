using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
           
            long[] numbers = new long[number];

            numbers[0] = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                long sum = 0;
                for (int j = i - 1; j >= 0 && j >= i-step; j--)
                { 
                        sum += numbers[j];
                       
                }
                numbers[i] = sum;
            }   
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
