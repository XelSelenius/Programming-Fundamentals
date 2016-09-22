using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static int GetMaxValue(int value1, int value2)
        {
            return Math.Max(value1, value2);
        }
        static char GetMaxValue(char value1, char value2)
        {
            if(value1>value2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
        static string GetMaxValue(string value1, string value2)
        {
            if (value1.CompareTo(value2) >= 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int value1 = int.Parse(Console.ReadLine());
                int value2 = int.Parse(Console.ReadLine());
                int max = GetMaxValue(value1, value2);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char value1 = char.Parse(Console.ReadLine());
                char value2 = char.Parse(Console.ReadLine());
                char max = GetMaxValue(value1, value2);
                Console.WriteLine(max);
            }
            else if(type=="string")
            {
                string value1 =Console.ReadLine();
                string value2 = Console.ReadLine();
                string max = GetMaxValue(value1, value2);
                Console.WriteLine(max);
            }
            
        }
    }
}
