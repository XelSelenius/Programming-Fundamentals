using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Task11
    {
        static double CalculateAreaOfTriangle()
        {
            double side = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            return (side* hight)/2;
        }
        static double CalculateAreaOfSquare()
        {
            double side = double.Parse(Console.ReadLine());
            return side * side;
        }
        static double CalculateAreaOfRectangle()
        {
            double width= double.Parse(Console.ReadLine());
            double hight= double.Parse(Console.ReadLine());
            return width * hight;
        }
        static double CalculateAreaOfCircle()
        {
            double radius = double.Parse(Console.ReadLine());
            return Math.PI * radius * radius;
        }
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    Console.WriteLine("{0:F2}",CalculateAreaOfTriangle());
                    break;
                case "square":
                    Console.WriteLine("{0:F2}", CalculateAreaOfSquare());
                    break;
                case "rectangle":
                    Console.WriteLine("{0:F2}", CalculateAreaOfRectangle());
                    break;
                case "circle":
                    Console.WriteLine("{0:F2}", CalculateAreaOfCircle());
                    break;
            }
        }
    }
}
