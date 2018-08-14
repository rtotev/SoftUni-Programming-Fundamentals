using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] clearSeparator = input.Split(' ', ',', '.', ';', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']');
            List<string> strings = new List<string>();
            foreach (string str in clearSeparator)
            {
                strings.Add(str);
            }    
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();
            List<string> lower = new List<string>();
            foreach (string str in strings)
            {
                int counterLower = 0;            
                int counterUpper = 0;
                int counterMixed = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]) == true)
                    {
                        counterLower++;     
                    }
                    else if (char.IsUpper(str[i]) == true)
                    {
                        counterUpper++;
                    }
                    else
                    {
                        counterMixed++;
                    }
                }

                if ((counterLower != 0) && (counterUpper == 0) && (counterMixed == 0))
                {
                    lower.Add(str);
                }
                else if ((counterLower == 0) && (counterUpper != 0) && (counterMixed == 0))
                {
                    upper.Add(str);
                }
                else if ((counterLower != 0) && (counterUpper != 0) || (counterMixed != 0))
                {
                    mixed.Add(str);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lower));            
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));            
            Console.WriteLine("Upper-case: " + string.Join(", ", upper));
        }
    }
}
