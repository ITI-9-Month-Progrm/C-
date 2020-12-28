using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeDPoint
{
    class _3DPoint:IComparable,ICloneable
    {
        int width, high, length;
        //answer 1 

        public _3DPoint(int x, int y, int z)
        {
            width = x;
            length = y;
            high = z;
        }
        //copy constructor 
        public _3DPoint(_3DPoint oldPoint)
        {
            width = oldPoint.width;
            length = oldPoint.length;
            high = oldPoint.high;
            Console.WriteLine("Copy Cotr");
        }
        //setter and getter
        public int Width
        {
            set { width = value; }
            get { return width; }
        }
        public int Length
        {
            set { length = value; }
            get { return length; }

        }
        public int High
        {
            set { high = value; }
            get { return high; }

        }
        //answer 2
        public override string ToString()
        {
            return $"X_Coordinate :{ width} Y_Coordinate :{length} Z_Coordinate {high} ";

        }

        //cast overloding
        //string x =(string )point;
        public static explicit operator string(_3DPoint point)
        {
            string res = "";
            res += "X:";
            res += point.width;
            res += "Y:";
            res += point.length;
            res += "Z:";
            res += point.high;
            return res;
        }
        
        //answer 4
        public static bool operator ==(_3DPoint point1, _3DPoint point2)
        {

            return ((point1.Width == point2.Width) && (point1.Length == point2.Length) && (point1.High == point2.High));
        }
        public static bool operator !=(_3DPoint point1, _3DPoint point2)
        {
            return ((point1.Width != point2.Width) || (point1.Length != point2.Length) || (point1.High != point2.High));
        }
        public override bool Equals(object obj)
        {
            _3DPoint p = (_3DPoint)obj;
            return  ((width == p.Width) && (length == p.Length) &&(high==p.High));
        }

        //answer 5
        public int CompareTo(object obj)
        {
            _3DPoint Right = (_3DPoint)obj; ///UnSafe

             if (width == Right.Width)
            {
                return length.CompareTo(Right.Length);
            }
            else { return width.CompareTo(Right.Width); }

        }
        //answer 6
        public object Clone()
        {
            return new _3DPoint(this);
            

        }

    }
}