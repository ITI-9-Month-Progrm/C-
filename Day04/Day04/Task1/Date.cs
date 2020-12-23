using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    struct Date
    {
        int day, month, year;
        Date (int _d,int _m,int _y)
        {
            day = _d;
            month = _m;
            year = _y;
        }
        //answer 9
        public void setDay(int _D) { day = _D; }
        public void setMonth(int _M) { month = _M; }
        public void setYear(int _Y) { year = _Y; }
        public int getDay() { return day; }
        public int getMonth() { return month; }
        public int getYear() { return year; }

        //setter and getter
        //answer 16
        public int Day
        {
            set { day = value; }
            get { return day; }
        }
        public int Month
        {
            set { month = value; }
            get { return month; }
        } 
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
