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

        public int CompareHours(DateTime dateTime1, DateTime dateTime2)
        {
            return TimeSpan.Compare(dateTime1.TimeOfDay, dateTime2.TimeOfDay);
        }

        public void PrintHoursComparisonResult(DateTime dateTime1, DateTime dateTime2)
        {
            int areObjectsEqual = CompareHours(dateTime1, dateTime2);
            switch (areObjectsEqual)
            {
                case -1:
                    Console.WriteLine($"{dateTime1} is shorter then {dateTime2}");
                    break;
                case 0:
                    Console.WriteLine($"{dateTime1} is equal to {dateTime2}");
                    break;
                case 1:
                    Console.WriteLine($"{dateTime1} is longer than {dateTime2}");
                    break;
            }
        }

        public List<DateTime> SortTimes(List<DateTime> dateTimeList)
        {
            for (int i = 1; i < dateTimeList.Count; i++)
            {
                for (int j = 0; j < dateTimeList.Count - i; j++)
                {
                    if(CompareHours(dateTimeList[j], dateTimeList[j+1]) == 1)
                    {
                        DateTime highDate = dateTimeList[j];
                        dateTimeList[j] = dateTimeList[j + 1];
                        dateTimeList[j + 1] = highDate;
                    }
                }
            }
            return dateTimeList;
        }


    }
}
