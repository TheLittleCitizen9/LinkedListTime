using System;

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
        }
    }
}
