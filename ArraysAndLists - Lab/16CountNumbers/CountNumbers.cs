using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>();
            foreach (string str in input)
            {
                numbers.Add(int.Parse(str));
            }
            Dictionary<int, int> result = new Dictionary<int, int>();

            List <int> answer = new List<int>();
            List<int> numberCounts = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int counter = 0;
                for (int j  = 0; j < numbers.Count; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if (answer.Contains(numbers[i]) == false)
                {
                    answer.Add(numbers[i]);
                    numberCounts.Add(counter);
                    result.Add(numbers[i], counter);
                }               
            }
            var resultList = result.Keys.ToList();
            resultList.Sort();
            foreach (var key in resultList)
            {
                Console.WriteLine("{0} -> {1}", key, result[key]);
            }
        }
    }
}
