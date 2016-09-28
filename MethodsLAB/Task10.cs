using System;

class PriceChangeAlert
{
    private static string GetMessage(double secondPrice, double firstPrice, double difference, bool isSignificantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", secondPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, secondPrice, difference);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, secondPrice, difference);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, secondPrice, difference);
        }
        return message;
    }
    private static bool EstimateDifference(double significance, double difference)
    {
        if (Math.Abs(significance) >= difference*100)
        {
            return true;
        }
        return false;
    }

    static double GetPercentage(double firstPrice, double price)
    {
        return ((price - firstPrice) / firstPrice)*100;
    }
    static void Main()
    {
        int priceNumber = int.Parse(Console.ReadLine());
        double significance = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        for (int i = 0; i < priceNumber - 1; i++)
        {
            double secondPrice = double.Parse(Console.ReadLine());
            double difference = GetPercentage(firstPrice, secondPrice);
            bool isSignificantDifference = EstimateDifference(difference, significance);
            string message = GetMessage(secondPrice, firstPrice, difference, isSignificantDifference);
            Console.WriteLine(message);
            firstPrice = secondPrice;
        }
    }
}
