using System;

namespace Task1
{

    public struct Date
    {
        int Day, Month, Year;
        public Date(int _D, int _M, int _Y)
        {
            Day = _D;
            Month = _M;
            Year = _Y;

        }


        //answer 7
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        //answer 8
        public void setDay(int _D) { Day = _D; }
        public void setMonth(int _M) { Month = _M; }
        public void setYear(int _Y) { Year = _Y; }
        public int getDay() { return Day; }
        public int getMonth() { return Month; }
        public int getYear() { return Year; }
    }

}