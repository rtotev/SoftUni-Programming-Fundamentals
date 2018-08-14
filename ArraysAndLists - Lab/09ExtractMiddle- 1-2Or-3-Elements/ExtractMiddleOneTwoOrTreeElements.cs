using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ExtractMiddle__1_2Or_3_Elements
{
    class ExtractMiddleOneTwoOrTreeElements
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strToArr = str.Split(' ').ToArray();
            int key = (strToArr.Length) / 2;
            if (strToArr.Length == 1)
            {
                Console.WriteLine('{' + strToArr[0] + '}');
            }
            else if (strToArr.Length % 2 == 0)
            {
                Console.WriteLine('{' + strToArr[key-1] + ", " + strToArr[key] + '}');
            }
            else if (strToArr.Length % 2 != 0)
            {
                Console.WriteLine('{' + strToArr[key - 1] + ", " + strToArr[key] + ", " + strToArr[key + 1] + '}');
            }
        }
    }
}
