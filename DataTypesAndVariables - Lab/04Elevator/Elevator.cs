using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int elevatorCourse = (person / elevatorCapacity);
            if (person % elevatorCapacity > 0)
            {
                elevatorCourse += 1;
            }
            Console.WriteLine(elevatorCourse);
        }
    }
}
