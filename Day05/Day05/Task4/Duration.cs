using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Duration
    {
        int hours, minutes, seconds;

        public Duration()
        {
            hours = minutes = seconds = 0;
        }
        public Duration (int h,int m,int s)
        {
            int remain, total,res;
            bool flag;
            if (m <= 60 && s <= 60)
            {
                hours = h;
                minutes = m;
                seconds = s;
            }
            else
            {
                flag = false;
                while (!flag)
                {
                    if (s > 60)
                    {
                        res = (int)(s / 60);
                        remain = s - (res * 60);
                        s = remain;
                        m += res;

                        res = (int)(m / 60);//13 h
                        remain = m - (res * 60);//22 min
                        hours = h + res;   //h+13 hours
                        minutes = remain; // 802 - 780}


                    }
                    else if(m>60)
                    {
                        res = (int)(m / 60);//13 h
                        remain = m - (res * 60);//20 min
                        hours = h + res;   //h+13 hours
                        minutes = remain; // 800 - 780 
                        seconds = s;
                    }
                    flag = true;

                }
            }
       
        }

        public Duration(Duration oldDuration)
        {
            hours = oldDuration.hours;
            minutes = oldDuration.minutes;
            seconds = oldDuration.seconds;
        }

        public Duration (int totalSec)
        {
            int remain;
            remain = 0;
            if(totalSec >= 3600) {
                hours = (int)(totalSec / 3600);
                remain = totalSec - (hours * 3600);
                minutes = (int)(remain/ 60);
                remain -= minutes * 60;
                seconds = (int)(remain);
            }
            else
            {
                minutes = (int)(totalSec/ 60);
                remain =totalSec-( minutes * 60);
                seconds = (int)(remain);
            }
            
        }
        public int Hours
        {
            set { hours = value; }
            get { return hours; }
        }
        public int Minutes
        {
            set { minutes = value; }
            get { return minutes; }
        }
        public int Seconds
        {
            set { seconds = value; }
            get { return seconds; }
        }
        public override string ToString()
        {
            if (hours == 0) 
            { 
                return $"\n\t\tMinutes : {minutes} Seconds : {seconds} ";
            }
            else 
            {
                return $"\n\t\tHours : {hours} Minutes : {minutes} Seconds : {seconds} ";
            }
            
        }
        public override bool Equals(object obj)
        {
            Duration D = (Duration)obj;

            return ((hours == D.hours) && (minutes == D.minutes) && (seconds == D.seconds));
        }
        public static Duration operator +(Duration D1,Duration D2)
        {
            int h, m, s;
            
            h = D1.Hours + D2.Hours;
            m = D1.Minutes + D2.Minutes;
            s = D1.Seconds + D2.Seconds;
            Duration D = new Duration(h,m,s);
            return D;
        }
        public static Duration operator +(Duration D1, int totalSec)
        {
            int h, m, s;
            Duration D2 = new Duration(totalSec);
            h = D1.Hours + D2.Hours;
            m = D1.Minutes + D2.Minutes;
            s = D1.Seconds + D2.Seconds;
            Duration D = new Duration(h, m, s);
            return D;
        }
        public static Duration operator +(int totalSec,Duration D1)
        {
            
            int h, m, s;
            Duration D2 = new Duration(totalSec);
            h = D1.Hours + D2.Hours;
            m = D1.Minutes + D2.Minutes;
            s = D1.Seconds + D2.Seconds;
            Duration D = new Duration(h,m,s);
            return D;
        }

        public static explicit  operator DateTime(Duration v)
        {
            int h, m, s;
            h = v.Hours;m = v.Minutes;s = v.Seconds;
            DateTime obj = new DateTime(2020,12,29,h,m,s);

                
            return obj ;
        }

        public static Duration operator ++(Duration D1)
        {

            D1.Minutes += 1;
            if (D1.Minutes % 60 == 0 )
            {
                D1.Hours += 1;
                D1.Minutes =D1.Minutes - 60;
                return D1;
            }
            else
            {
                return D1;
            }
            
        }
        public static Duration operator --(Duration D1)
        {

            if(D1.Minutes == 0)
            {
                D1.Hours -= 1;
                D1.Minutes = 59;
                return D1;
            }
            else
            {
                D1.Minutes -= 1;
                return D1;
            }

        }
        public static Duration operator -(Duration D1,Duration D2)
        {
            if (D1 > D2) {
                D1.Hours -= D2.Hours;
                D1.Minutes -= D2.Minutes;
                D1.Seconds -= D2.Seconds;
                return D1;
            }
            else
            {
                D2.Hours -= D1.Hours;
                D2.Minutes -= D1.Minutes;
                D2.Seconds -= D1.Seconds;
                return D2;
            }
            

        }
        public static bool operator >(Duration D1, Duration D2) {
            if(D1.Hours > D2.Hours)
            {
                return true;
            }
            else if(D1.Hours == D2.Hours)
            {
                if(D1.Minutes > D2.Minutes) { return true; }
                else if(D1.Minutes == D2.Minutes)
                {
                    return D1.Seconds > D2.Seconds;
                }
                else { return false; }
            }
            else { return false; }
           // return ((D1.Hours > D2.Hours) && (D1.Minutes > D2.Minutes) && (D1.Seconds > D2.Seconds)) ;
        }
        public static bool operator <(Duration D1, Duration D2) {
            if (D1.Hours < D2.Hours)
            {
                return true;
            }
            else if (D1.Hours == D2.Hours)
            {
                if (D1.Minutes < D2.Minutes) { return true; }
                else if (D1.Minutes == D2.Minutes)
                {
                    return D1.Seconds < D2.Seconds;
                }
                else { return false; }
            }
            else { return false; }
            //return ((D1.Hours < D2.Hours) && (D1.Minutes < D2.Minutes) && (D1.Seconds < D2.Seconds));
        }
        public static bool operator >=(Duration D1, Duration D2)
        {
            return ((D1.Hours >= D2.Hours) && (D1.Minutes >= D2.Minutes) && (D1.Seconds >= D2.Seconds));
        }
        public static bool operator <=(Duration D1, Duration D2)
        {
            return ((D1.Hours <= D2.Hours) && (D1.Minutes <= D2.Minutes) && (D1.Seconds <= D2.Seconds));
        }
        public static bool operator true (Duration D)
        {
            return ((D.Hours != 0) || (D.Minutes != 0) || (D.Seconds != 0));
        }
        public static bool operator false(Duration D)
        {
            return ((D.Hours == 0) && (D.Minutes == 0) && (D.Seconds == 0));
        }
    }
}
