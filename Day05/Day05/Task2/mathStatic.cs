using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class mathStatic
    {
        
        public static int Add(int Num1, int Num2)
        {
            int sum = 0;
            sum = Num1 + Num2;
            return sum;

        }
        public static int Subtract(int Num1, int Num2)
        {
            int sub;
            sub = Num1 - Num2;
            return sub;
        }
        public static int Multiply(int Num1, int Num2)
        {
            int mulp;
            mulp = Num1 * Num2;
            return mulp;
        }
        public static double Divide(int Num1, int Num2)
        {
            double div;
            div = (double)Num1 / Num2;
            return div;
        }
    }
}
