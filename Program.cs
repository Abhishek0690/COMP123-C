using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class date
    {
        private int year;
        private int month;
        private int day;

        public date(int day, int month, int year) { this.day = day; this.month = month; this.year = year; }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        public void Add(int days)
        {
            day += days;
        }
        public void Add(int days, int months)
        {
            day += days;
            month += months;
        }
        public void Add(date other)
        {
            day += day;
            month += month;
            year += year;
        }
        private void Normalize()
        {
            if (month > 12)
            {
                do
                {
                    month -= 12;
                    year += 1;
                }
                while (month > 12);
            }
            if (day > 30)
            {
                do
                {
                    day -= 30;
                    month += 1;
                }
                while(day > 30);
            }

        }
        static void Main(string[] args)
        {
            date lab2 = new date(1, 12, 2003);
            Console.WriteLine(lab2);
            lab2.Add(50);
           lab2.Normalize();
            Console.WriteLine(lab2);
            lab2.Add(1, 4);
            lab2.Normalize();
            Console.WriteLine(lab2);
            lab2.Add(lab2);
           lab2.Normalize();
            Console.WriteLine(lab2);
        }
        
    }
}
