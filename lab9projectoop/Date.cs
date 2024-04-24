using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9projectoop
{
    internal class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > 31)
                    throw new Exception("Invalid day");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new Exception("Invalid month");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                    throw new Exception("Invalid year");
                year = value;
            }
        }
        //  Зроби щоб я вручну вказував дату щоб перевірити як працюють виключення
        public void AddDays(int days)
        {
            DateTime dt = new DateTime(Year, Month, Day);
            dt = dt.AddDays(days);
            Day = dt.Day;
            Month = dt.Month;
            Year = dt.Year;
        }

        public void AddMonths(int months)
        {
            DateTime dt = new DateTime(Year, Month, Day);
            dt = dt.AddMonths(months);
            Day = dt.Day;
            Month = dt.Month;
            Year = dt.Year;
        }

        public void AddYears(int years)
        {
            DateTime dt = new DateTime(Year, Month, Day);
            dt = dt.AddYears(years);
            Day = dt.Day;
            Month = dt.Month;
            Year = dt.Year;
        }
    }
}