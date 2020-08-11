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
    }
}
