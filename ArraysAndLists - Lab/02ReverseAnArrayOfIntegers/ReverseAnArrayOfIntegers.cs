using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int[] reversedNumbers = new int[numbers.Length];
            for (int i = 0; i < reversedNumbers.Length; i++)
            {
                reversedNumbers[i] = numbers[numbers.Length - 1 - i]; 
            }
            Console.WriteLine(string.Join(" ", reversedNumbers));
        }
    }
}
