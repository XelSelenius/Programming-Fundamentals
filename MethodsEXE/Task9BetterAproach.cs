using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9BetterAproach
{
    class Task9BetterAproach
    {
        static double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        static void GetClosestToCenter(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) > Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
            static void Main(string[] args)
        {
            double xI1 = double.Parse(Console.ReadLine());
            double yI1 = double.Parse(Console.ReadLine());
            double xI2 = double.Parse(Console.ReadLine());
            double yI2 = double.Parse(Console.ReadLine());
            double xII1 = double.Parse(Console.ReadLine());
            double yII1 = double.Parse(Console.ReadLine());
            double xII2 = double.Parse(Console.ReadLine());
            double yII2 = double.Parse(Console.ReadLine());
            
            double distanceFirst = DistanceBetweenTwoPoints(xI1, yI1, xI2, yI2);
            double distanceSecond = DistanceBetweenTwoPoints(xII1, yII1, xII2, yII2);

            if (distanceSecond > distanceFirst)
            {
                GetClosestToCenter(xII1, yII1, xII2, yII2);
            }
            else if (distanceFirst > distanceSecond)
            {
                GetClosestToCenter(xI1, yI1, xI2, yI2);
            }
        }
    }
}
