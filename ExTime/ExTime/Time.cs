using System;
using System.Collections.Generic;
using System.Text;

namespace ExTime
{
    public class Time
    {
        public void PrintCurrentTime()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss.tt"));
        }

        public string AddHours(DateTime dateTime1, DateTime dateTime2)
        {
            dateTime1 = dateTime1.AddHours(dateTime2.Hour);
            dateTime1 = dateTime1.AddMinutes(dateTime2.Minute);
            dateTime1 = dateTime1.AddSeconds(dateTime2.Second);

            return $"{dateTime1.Hour}:{dateTime1.Minute}:{dateTime1.Second}";
        }

        public string SubtractHours(DateTime dateTime1, DateTime dateTime2)
        {
            if(dateTime1.Hour > dateTime2.Hour)
            {
                TimeSpan timeSpan = dateTime1.Subtract(dateTime2);
                return $"{timeSpan.Hours}:{timeSpan.Minutes}:{timeSpan.Seconds}";
            }
            else
            {
                TimeSpan timeSpan = dateTime2.Subtract(dateTime1);
                return $"{timeSpan.Hours}:{timeSpan.Minutes}:{timeSpan.Seconds}";
            }
        }


    }
}
