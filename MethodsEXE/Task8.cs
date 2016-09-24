using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Task8
    {
        static void GetClosestToCenterSMART(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(Math.Pow(x1,2) + Math.Pow(y1,2)) > Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
        static void GetClosestToCenter(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1 + y1) > Math.Abs(x2 + y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            GetClosestToCenterSMART(x1, y1, x2, y2);
            //GetClosestToCenter(x1, y1, x2, y2);
        }
    }
}
