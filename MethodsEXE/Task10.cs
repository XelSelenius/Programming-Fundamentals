using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Task10
    {
        static double CalculateCubeFace(double side)
        {
            return Math.Sqrt(2 * Math.Pow(side, 2));
        }
        static double CalculateCubeVolume(double side)
        {
            return Math.Pow(side, 3);
        }
        static double CalculateCubeSpaceDiagonal(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));

        }
        static double CalculateCubeArea(double side)
        {
            return 6 * Math.Pow(side, 2);
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string toReturn = Console.ReadLine();
            switch (toReturn)
            {
                case "face":
                    Console.WriteLine("{0:F2}", CalculateCubeFace(side));
                    break;
                case "volume":
                    Console.WriteLine("{0:F2}", CalculateCubeVolume(side));
                    break;
                case "space":
                    Console.WriteLine("{0:F2}", CalculateCubeSpaceDiagonal(side));
                    break;
                case "area":
                    Console.WriteLine("{0:F2}",CalculateCubeArea(side));
                    break;
            }
        }
    }
}
