using System;

class PriceChangeAlert
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double diff = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < number - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double differance = countDiff(lastPrice, currentPrice);
            bool isSignificantDifference = isDifferance(differance, diff);
            string message = Get(currentPrice, lastPrice, differance, isSignificantDifference);
            lastPrice = currentPrice;
            Console.WriteLine(message);
            
        }
    }

    private static string Get(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, Math.Round(difference*100, 2));
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, Math.Round(difference * 100, 2));
        }
        else if (etherTrueOrFalse && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, Math.Round(difference * 100, 2));
        return to;
    }
    private static bool isDifferance(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double countDiff(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;
        return result;
    }
}