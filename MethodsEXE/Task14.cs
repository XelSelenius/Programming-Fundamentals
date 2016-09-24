using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            string numDigits = sum.ToString();
            int counter = 0;
            int[] arrayOfNumbers = new int[numDigits.Length];
            counter = 0;
            while (sum != 0)
            {
                int lastDigit = (int) (sum % 10);
                arrayOfNumbers[counter] = lastDigit;
                counter++;
                sum = sum / 10;
            }
            int numOfZeros = 0;
            for (int z = 0; z < arrayOfNumbers.Length; z++)
            {
                if(arrayOfNumbers[z]!=0)
                {
                    break;
                }
                numOfZeros++;
            }
            Console.WriteLine(numOfZeros);
        }
    }
}
