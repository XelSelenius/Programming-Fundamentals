using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void PrintHederRow(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        static void PrintBody(int n)
        {
            for (int j = 1; j <= n-2; j++)
            {
                Console.Write("-");
                for (int i = 1; i <= n-1; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHederRow(n);
            PrintBody(n);
            PrintHederRow(n);
        }
    }
}
