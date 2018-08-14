using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int ones = i % 10;
                int tens = (i / 10) % 10;
                int houdreds = (i / 100) % 10;
                int specialNumbers = ones + tens + houdreds;
                Console.WriteLine("{0}->" + (specialNumbers == 5 || specialNumbers == 7 || specialNumbers == 11), i);                       
            }
        }
    }
}
