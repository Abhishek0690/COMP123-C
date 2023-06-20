using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    enum TimeFormat { Mil, Hour12, Hour24}
    class Time
    {
        private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;
        public int Hour { get; }
        public int Minute { get; }
        public Time(int hour = 0, int minute = 0 )
        {
            if (hour >= 0 && hour <= 24)
                Hour = hour;
            else
                Hour = 0;

            if (minute >= 0 && minute <= 60)
                Minute = minute;
            else
                Minute = 0;
        }
        public override string ToString()
        {
            int h;
            int m;
            string D;
            if (Hour > 12) { D = "PM"; }
            else { D = "AM"; }
            switch (TIME_FORMAT)
            {
                case TimeFormat.Hour12:
                    if (Hour > 12)
                    {
                      h = Hour - 12;
                      m = Minute;
                    }
                    else { h = Hour; m = Minute; }
                    
                    Console.WriteLine($"{h:d2}:{m:d2} {D}");
                    break;
                case TimeFormat.Mil:
                    Console.WriteLine($"{Hour:d2}{Minute:d2}");
                    break;
                case TimeFormat.Hour24:
                    Console.WriteLine($"{Hour:d2}:{Minute:d2}");
                    break;
            }
            return $"";
        }
        static public void SetFormat(TimeFormat timeFormat)
        {
            TIME_FORMAT = timeFormat;
        }
    }
    internal class time
    {
        
    }
}
