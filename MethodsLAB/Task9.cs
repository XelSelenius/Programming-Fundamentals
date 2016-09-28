using System;
using System.Globalization;

class Task9
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", null);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", null);
        var holidaysCount = 0;
        int n = 0;
        for (var date = startDate; date <= endDate; date = startDate.AddDays(n))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
                n++;
            }
            else
            {
                n++;
            }
        }
        Console.WriteLine(holidaysCount);
    }
}