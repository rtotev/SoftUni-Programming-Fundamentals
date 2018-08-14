using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            try
            {
                long tryFitToLong = (long)number;
                Console.WriteLine("{0} can fit in:", number);
                sbyte fitToSbyte = (sbyte)tryFitToLong;
                if (fitToSbyte == tryFitToLong)
                {
                    Console.WriteLine("* sbyte");
                }
                byte fitToByte = (byte)tryFitToLong;
                if (fitToByte == tryFitToLong)
                {
                    Console.WriteLine("* byte");
                }
                short fitToShort = (short)tryFitToLong;
                if (fitToShort == tryFitToLong)
                {
                    Console.WriteLine("* short");
                }
                ushort fitToUshort = (ushort)tryFitToLong;
                if (fitToUshort == tryFitToLong)
                {
                    Console.WriteLine("* ushort");
                }               
                int fitToInt = (int)tryFitToLong;
                if (fitToInt == tryFitToLong)
                {
                    Console.WriteLine("* int");
                }
                uint fitToUint = (uint)tryFitToLong;
                if (fitToUint == tryFitToLong)
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", number);
            }
        }
    }
}
