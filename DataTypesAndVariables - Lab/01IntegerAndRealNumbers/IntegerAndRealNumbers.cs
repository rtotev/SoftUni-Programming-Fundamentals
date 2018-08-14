using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01IntegerAndRealNumbers
{
    class IntegerAndRealNumbers
    {
        static void Main(string[] args)
        {
            
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;    
            Console.WriteLine("{0} centuriesm = {1} years = {2} days = {3} hours = {4} minutes",
                centuries, years, days, hours, minutes);
        }
    }
}
