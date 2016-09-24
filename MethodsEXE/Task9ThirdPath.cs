using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9ThirdPath
{
    class Task9ThirdPath
    {

        static double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        static double GetClosestToCenterSMART(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
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

            if (DistanceBetweenTwoPoints(xI1, yI1, xI2, yI2) >=
                 DistanceBetweenTwoPoints(xII1, yII1, xII2, yII2))
            {
                if (GetClosestToCenterSMART(xI1, yI1) <= GetClosestToCenterSMART(xI2, yI2))
                {
                    Console.WriteLine($"({xI1}, {yI1})({xI2}, {yI2})");
                }
                else
                {
                    Console.WriteLine($"({xI2}, {yI2})({xI1}, {yI1})");
                }
            }
            else
            {
                if (GetClosestToCenterSMART(xII1, yII1) <= GetClosestToCenterSMART(xII2, yII2))
                {
                    Console.WriteLine($"({xII1}, {yII1})({xII2}, {yII2})");
                }
                else
                {
                    Console.WriteLine($"({xII2}, {yII2})({xII1}, {yII1})");
                }
            }

        }
    }
}