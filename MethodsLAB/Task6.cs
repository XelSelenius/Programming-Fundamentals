using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static double GetPowerNum(double num, double power)
        {
            return Math.Pow(num, power);
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = GetPowerNum(num, power);
            Console.WriteLine(result);
        }
    }
}
