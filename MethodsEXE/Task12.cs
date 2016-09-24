using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Task12
    {
        static bool CheckSymethry(int i)
        {
            string digits = i.ToString();
            for (int j = 0; j <= digits.Length - 1; j++)
            {
                if (digits[j] != digits[(digits.Length - 1) - j])
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckDivision(int i)
        {

            int num = i;
            int counter = 0;
            while (num != 0)
            {
                int lastDigit = i%10;
                counter++;
                num = num/10;
            }
            int[] arrayOfNumbers = new int[counter];
            counter = 0;
            while (i != 0)
            {
                int lastDigit = i%10;
                arrayOfNumbers[counter] = lastDigit;
                counter++;
                i = i/10;
            }
            int sum = 0;
            for (int z = 0; z < arrayOfNumbers.Length; z++)
            {
                sum += arrayOfNumbers[z];
            }
            if (sum%7 != 0)
            {
                return false;
            }
            return true;
        }

        static bool CheckEvenNumber(int i)
        {
            string even = i.ToString();
            for (int k = 0; k < even.Length; k++)
            {
                if (even[k]%2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                bool symethry = CheckSymethry(i);
                bool division = CheckDivision(i);
                bool evenNum = CheckEvenNumber(i);
                if (symethry == true && division == true && evenNum == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
