using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8SecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            string nums = Console.ReadLine();
            int sumEven = 0;
            int sumOdd = 0;

            foreach (int item in nums)
            {
                if (item == '-')
                {
                    continue;
                }
                int fAscii = item - 48;
                if (Math.Abs(fAscii) % 2 == 0)
                {
                    sumEven += fAscii;
                }
                else
                {
                    sumOdd += fAscii;
                }
            }
            Console.WriteLine(sumOdd * sumEven);

        }
    }
}
