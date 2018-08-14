using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split('|');
            List<string> inputList = new List<string>();
            foreach (string str in inputString)
            {
                inputList.Add(str);
            }
            inputList.Reverse();            
            Console.WriteLine(string.Join(" ", inputList));
         }
    }
}
