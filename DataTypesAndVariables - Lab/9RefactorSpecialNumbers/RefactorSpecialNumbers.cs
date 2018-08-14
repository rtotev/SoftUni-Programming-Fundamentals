using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int insertedNumber = int.Parse(Console.ReadLine());
            int sumDiggit = 0;
            int currentNumber = 0;
            bool specialNumber = false;
            for (int i = 1; i <= insertedNumber; i++)
            {
                currentNumber = i;
                while (i > 0)
                {
                    sumDiggit += i % 10;
                    i = i / 10;
                }
                specialNumber = (sumDiggit == 5) || (sumDiggit == 7) || (sumDiggit == 11);
                Console.WriteLine($"{currentNumber} -> {specialNumber}");
                sumDiggit = 0;
                i = currentNumber;
            }
        }
    }
}
