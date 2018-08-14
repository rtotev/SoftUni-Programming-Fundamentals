using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());
            double result = numberPower(number, powerNumber);
            Console.WriteLine(result);
        }

        static double numberPower(double num, double power)
        {
            return (Math.Pow(num, power));
        }
    }
}
