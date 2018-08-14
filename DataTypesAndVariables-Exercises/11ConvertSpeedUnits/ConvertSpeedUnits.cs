using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float meterPerSeconds = (distance / ((hours * 60f + minutes) * 60f + seconds));
            float kilometerPerHour = ((distance / 1000f) / (((hours * 60f + minutes) * 60 + seconds)/3600));
            float milesPerHour = (kilometerPerHour /1.609f);
            Console.WriteLine("{0}", (meterPerSeconds));
            Console.WriteLine("{0}", kilometerPerHour);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}
