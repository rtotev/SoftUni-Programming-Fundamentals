using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PricesChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double priceDifferenance = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < number - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double differance = countPercent(lastPrice, currentPrice);
                bool isSignificantDifference = isDifferance(differance, priceDifferenance);
                string message = GetString(currentPrice, lastPrice, differance, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        private static string GetString(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
        {
            string to = "";
            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, Math.Round(difference, 2));
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, Math.Round(difference, 2));
            }
            else if (etherTrueOrFalse && (difference < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, Math.Round(difference, 2));
            return to;
        }

        private static bool isDifferance(double priceDifferance, double isDifferance)
        {
            if (Math.Abs(priceDifferance) >= isDifferance)
            {
                return true;
            }
            return false;
        }

        private static double countPercent(double lastPrice, double currentprice)
        {
            double result = (currentprice - lastPrice) / lastPrice*100;
            return result;
        }
    }
}
