using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", firstNumber);
            Console.WriteLine("b = {0}", secondNumber);
            Console.WriteLine("After:");
            int thirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            Console.WriteLine("a = {0}", firstNumber);
            Console.WriteLine("b = {0}", secondNumber);
        }
    }
}
