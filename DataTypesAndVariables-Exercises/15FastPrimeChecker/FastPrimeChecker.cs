using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isPrimeNumber = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrimeNumber}");
            }
        }
    }
}
