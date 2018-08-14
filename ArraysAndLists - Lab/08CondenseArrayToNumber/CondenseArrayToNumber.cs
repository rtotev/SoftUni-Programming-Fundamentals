using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strToArr = str.Split(' ').ToArray();
            long[] numbers = new long[strToArr.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(strToArr[i]);
            }
            int counter = numbers.Length - 1;
            while (counter != 0)
            {
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    numbers[i] += numbers[i + 1]; 
                }
             counter -= 1;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
