using System;
using System.Collections.Generic;

namespace ExTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.PrintCurrentTime();
            Console.WriteLine(time.AddHours(new DateTime(2020, 08, 07, 17, 17, 17), new DateTime(2020, 08, 07, 16, 16, 16)));
            Console.WriteLine(time.SubtractHours(new DateTime(2020, 08, 07, 17, 17, 17), new DateTime(2020, 08, 07, 16, 16, 16)));
            time.PrintHoursComparisonResult(new DateTime(2020, 08, 07, 17, 17, 17), new DateTime(2020, 08, 07, 16, 16, 16));
            List<DateTime> dateTimesList = new List<DateTime>{ new DateTime(2020, 08, 07, 16, 16, 16), new DateTime(2020, 08, 07, 17, 17, 17)};
            dateTimesList = time.SortTimes(dateTimesList);
            foreach (var item in dateTimesList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
