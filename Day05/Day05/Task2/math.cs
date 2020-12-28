using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class math
    {
       
        
        public int Add(int Num1, int Num2) {
            int sum = 0;
            sum = Num1 + Num2;
            return sum;
            
        }
        public int Subtract(int Num1, int Num2) {
            int sub;
            sub = Num1 - Num2;
            return sub;
        }
        public int Multiply(int Num1, int Num2) {
            int mulp;
            mulp = Num1 * Num2;
            return mulp;
        }
        public double Divide(int Num1, int Num2)
        {
            double div;
            div = (double)Num1 / Num2;
            return div;
        }
    }
}
