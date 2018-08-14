using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17PrintPartOfTheASCIITable
{
    class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            int startCharNumber = int.Parse(Console.ReadLine());
            int endCharNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i <= endCharNumber-startCharNumber; i++)
            {
                Console.Write("{0} ", (char)(startCharNumber + i));
            }
        }
    }
}
