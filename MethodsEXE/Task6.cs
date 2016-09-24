using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Task6
    {
        static bool PrimeChecker(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            bool status = PrimeChecker(num);
            Console.WriteLine(status);
        }
    }
}
