using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13VowelOrDigit
{
    class VowelOrDiggit
    {
        static void Main(string[] args)
        {
            char inputChar = char.Parse(Console.ReadLine());
            if ((int)inputChar >= 48 && (int)inputChar <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u' || inputChar == 'y')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }

    }
}
