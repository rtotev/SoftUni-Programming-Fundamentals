using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object conctStrings = firstString + ' ' + secondString;
            string assignStringWhitCasting = (string)conctStrings;
            Console.WriteLine(assignStringWhitCasting);
        }
    }
}
