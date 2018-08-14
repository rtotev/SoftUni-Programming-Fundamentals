using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)('a' + i), (char)('a' + k), (char)('a' + j));
                    }
                }    
            }
        }
    }
}
