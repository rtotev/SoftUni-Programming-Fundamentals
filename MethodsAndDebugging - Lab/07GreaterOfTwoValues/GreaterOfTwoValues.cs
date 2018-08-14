using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string getType = Console.ReadLine();
            if (getType == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int result = getMaxValue(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (getType == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = getMaxValue(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (getType == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string result = getMaxValue(firstString, secondString);
                Console.WriteLine(result);             
            }            
        }

        static int getMaxValue(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return(firstNum);
            }
            else
            {
                return(secondNum);
            }
        }

        static char getMaxValue(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string getMaxValue(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
               return(first);
            }
            else
            {
                return(second);
            }
        }
    }
}
