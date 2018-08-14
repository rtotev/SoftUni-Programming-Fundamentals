using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputToArray = input.Split().ToArray();
            for (int i = 0; i < inputToArray.Length/2; i++)
            {
                string str = inputToArray[i];
                inputToArray[i] = inputToArray[inputToArray.Length-i-1];
                inputToArray[inputToArray.Length-1-i] = str;
            }
            Console.WriteLine(string.Join(" ", inputToArray));
        }
    }
}
