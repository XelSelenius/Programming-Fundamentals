using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Task9
    {
        static void DistanceBetweenTwoPoints(double xI1, double yI1, double xI2, double yI2, double xII1, double yII1, double xII2, double yII2)
        {
            double pointI1 = Math.Sqrt(Math.Pow(xI1, 2) + Math.Pow(yI1, 2));
            double pointI2 = Math.Sqrt(Math.Pow(xI2, 2) + Math.Pow(yI2, 2));
            double distanceFirst = Math.Sqrt(Math.Pow(pointI1, 2) + Math.Pow(pointI2, 2));
            double pointII1 = Math.Sqrt(Math.Pow(xII1, 2) + Math.Pow(yII1, 2));
            double pointII2 = Math.Sqrt(Math.Pow(xII2, 2) + Math.Pow(yII2, 2));
            double distanceSecond = Math.Sqrt(Math.Pow(pointII1, 2) + Math.Pow(pointII2, 2));
           
            if (distanceSecond > distanceFirst)
            {
                if (pointII1 > pointII2)
                {
                    Console.WriteLine($"({xII2}, {yII2})({xII1}, {yII1})");
                }
                else
                {
                    Console.WriteLine($"({xII1}, {yII1})({xII2}, {yII2})");
                }
            }
            else if (distanceFirst > distanceSecond)
            {
                if (pointI1 > pointI2)
                {
                    Console.WriteLine($"({xI2}, {yI2})({xI1}, {yI1})");
                }
                else
                {
                    Console.WriteLine($"({xI1}, {yI1})({xI2}, {yI2})");
                }
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
            DistanceBetweenTwoPoints(xI1, yI1, xI2, yI2, xII1, yII1, xII2, yII2);
        }
    }
}
