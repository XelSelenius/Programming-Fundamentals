using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Task8
    {
        static void MultyplyEvenByOdd(int n)
        {
            int sumEven = 0;
            int sumOdd = 0;
            while (n != 0)
            {
                int lastDigit = n%10;
                if (lastDigit%2 == 0)
                {
                    sumEven = sumEven + lastDigit;
                }
                else
                {
                    sumOdd = sumOdd + lastDigit;
                }
                n = n/10;
            }
            int reuslt = sumEven * sumOdd;
            Console.WriteLine(reuslt);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MultyplyEvenByOdd(n);
        }
    }
}
