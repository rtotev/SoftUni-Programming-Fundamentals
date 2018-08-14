using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputToArray = input.Split(' ').ToArray();
            double[] numbers = new double[inputToArray.Length];
            double[] raundedNumbers = new double[inputToArray.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(inputToArray[i]);
                raundedNumbers[i] = Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", numbers[i], raundedNumbers[i]);
            } 
        }
    }
}
