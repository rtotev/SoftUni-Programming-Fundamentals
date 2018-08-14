using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            string[] listString = Console.ReadLine().Split(' ').ToArray();
            int[] intArray = new int[listString.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(listString[i]);
            } 
            List<int> list = new List<int>();                
            foreach (var item in intArray)
            {
                if (item >= 0)
                {
                    list.Add(item);
                }                                           
            }              
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                list.Reverse();
                string answer = string.Join(" ", list);
                Console.WriteLine(answer);
            }            
        }
    }
}
