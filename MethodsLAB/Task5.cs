using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static double GetTriangleArea(double side, double hight)
        {
            return side * hight / 2;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double area=GetTriangleArea(side, hight);
            Console.WriteLine(area);
        }
    }
}
