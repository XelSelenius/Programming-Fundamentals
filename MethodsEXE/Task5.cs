using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Task5
    {
        static void Fibonachi(int n)
        {
            int fiboFirst = 1;
            int fiboSecond = 1;
            int fiboThird = 1;
            for (int i = 2; i <= n; i++)
            {

                fiboThird = fiboFirst + fiboSecond;

                fiboFirst = fiboSecond;
                fiboSecond = fiboThird;
            }
            Console.WriteLine(fiboThird);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fibonachi(n);
        }
    }
}
