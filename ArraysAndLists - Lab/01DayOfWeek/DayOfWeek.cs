using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(days[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }                 
        }
    }
}
