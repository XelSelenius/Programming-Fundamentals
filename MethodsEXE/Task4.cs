using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Task4
    {
        static void ReverseNum(decimal num)
        {
            string number = num.ToString();
            for (int i = number.Length-1; i >= 0; i--)
            {
                Console.Write("{0}", number[i]);
            }
            
        }
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            ReverseNum(num);
        }
    }
}
