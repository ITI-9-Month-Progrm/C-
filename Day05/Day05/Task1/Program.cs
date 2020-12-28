using System;

namespace ThreeDPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            _3DPoint p1=new _3DPoint(0,0,0), 
                p2= new _3DPoint(1, 2, 3),
                p3 = new _3DPoint(4, 5, 6),
                p4;
            
            
            int x, y, z;
            _3DPoint[] points = { new _3DPoint(1, 2, 3), new _3DPoint(1, 3, 3), new _3DPoint(1, 5, 4), new _3DPoint(8, 2, 3) };
            
            Console.Write("Please Enter x Coordinate:");

            if(int.TryParse(Console.ReadLine(), out x))
            {
                p1.Width = x;
            }
            Console.Write("Please Enter y Coordinate:");
            if (int.TryParse(Console.ReadLine(), out y))
            {
                p1.Length = y;
            }
            Console.Write("Please Enter z Coordinate");
            if (int.TryParse(Console.ReadLine(), out z))
            {
                p1.High = z;
            }
            string res;
            res = p1.ToString();
            Console.WriteLine(res);
            if (p1 == p2) { Console.WriteLine("True=="); }
            else { Console.WriteLine("false=="); }

            if (p1 != p3) { Console.WriteLine("True!="); }
            else { Console.WriteLine("false!="); }

            if (p1.Equals(p2)) { Console.WriteLine("TrueEq"); }
            else { Console.WriteLine("falseEq"); }

            if (p1.Equals(p3)) { Console.WriteLine("TrueEq"); }
            else { Console.WriteLine("falseEq"); }

            //sort points array
            Array.Sort(points);
            Console.WriteLine("-------------sorting Result------------");
            int len;
            string Sres;
            len = points.Length;
            for(int i = 0; i < len; i++)
            {
                Sres = points[i].ToString();
                Console.WriteLine(Sres);
            }
            //clone 
            p4=(_3DPoint)p3.Clone();
            Console.WriteLine("-------------Cloninging Result------------");
            Console.WriteLine((string)p4.ToString());

        }
    }
}
