using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintHeaderRow(number);
            for (int i = 0; i < number-2; i++)
            {
                PrintMiddleRow(number);
            }            
            PrintHeaderRow(number);
        }

        static void PrintHeaderRow(int num)
        {
            Console.WriteLine(new string('-', 2 * num));
        }

        static void PrintMiddleRow(int num)
        {           
            Console.Write("-");
            for (int i = 1; i < num; i++)
            {                
                Console.Write("\\/");                
            }
            Console.WriteLine("-");
        }
    }
}
