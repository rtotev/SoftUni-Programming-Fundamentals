using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long totalPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactorPercent = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            long totalSeconds = (long)(totalPictures * filterTime) + (long)((Math.Ceiling(totalPictures * filterFactorPercent / 100.0)) * uploadTime);
            Console.WriteLine("{0:0}:{1:00}:{2:00}:{3:00}", (Math.Floor(totalSeconds / 86400.0)), (totalSeconds / 3600) % 24, (totalSeconds / 60) % 60, totalSeconds % 60);
        }
    }
}
