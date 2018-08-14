using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = (centuries * 100);
            int days = (int)(years * 365.2422);
            long hours = days*24;
            ulong minutes = (ulong)(hours * 60);
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds *1000;
            decimal microseconds = milliseconds *1000m;
            decimal nanoseconds = microseconds * 1000m;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
