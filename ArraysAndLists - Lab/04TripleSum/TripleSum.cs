using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] numbersToString = inputString.Split(' ');
            int[] numbers = new int[numbersToString.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersToString[i]);
            }

            bool isContain = false;
            

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {

                    for (int c = 0; c < numbers.Length; c++)
                    {
                       
                       
                           if (numbers[a] + numbers[b] == numbers[c])
                           {
                               Console.WriteLine("{0} + {1} == {2}", numbers[a], numbers[b], numbers[c]);
                               isContain = true;
                               
                           }
                       
                    }
                }
            }        
            if (isContain == false)
            {
                Console.WriteLine("No");
            }
        }  
    }
}

