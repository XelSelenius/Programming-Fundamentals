using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void GetMaxNum(int num1,int num2,int num3)
        {
            Console.WriteLine(Math.Max(num3,Math.Max(num1,num2)));
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            GetMaxNum(num1, num2,num3);
        }
    }
}
