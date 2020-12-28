using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string res;
            Duration D  = new  Duration(1, 0 ,10);
            Duration D1 = new Duration(3600);
            Duration D2 = new Duration(7800);
            Duration D3 = new Duration(666);
            Duration D4 = new Duration(7866);
            Duration D5 = new Duration(),
                     D6 = new Duration(),
                     D7 = new Duration(),
                     D8 = new Duration(),
                     D9 = new Duration();


            res =D.ToString();
            Console.WriteLine("D : "+res);
            res= D1.ToString();
            Console.WriteLine("--------------------D1 : 3600-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            res = D2.ToString();
            Console.WriteLine("--------------------D2 : 7800-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            res = D3.ToString();
            Console.WriteLine("--------------------D3 : 666-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            res = D4.ToString();
            Console.WriteLine("--------------------D4 : 7866-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            D5 = D1 + D2;
            res = D5.ToString();
            Console.WriteLine("--------------------D5 = D1 + D2;-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            D6 = D1 + 7800;
            res = D6.ToString();
            Console.WriteLine("--------------------D6 = D1 + 7800;-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            D7 = 666 + D1;
            res = D7.ToString();
            Console.WriteLine("-------------------- D7 = 666 + D1;-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            D8 =D1++;
            res = D8.ToString();
            Console.WriteLine("-------------------- D1++-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            D9=--D2;
            res = D9.ToString();
            Console.WriteLine("--------------------(--D2)-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            D8-=D2;
            res = D8.ToString();
            Console.WriteLine("--------------------(D8-=D2;)-------------------");
            Console.WriteLine(res);
            Console.WriteLine();
            if (D) 
            { 
                Console.WriteLine("TRUE");
            } 
            else 
            {
               Console.WriteLine("FALAE"); 
            }
            DateTime Obj = (DateTime)D1;
        }
    }
}
