using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class math
    {
        int num1, num2;
        //setter and getter
        public math(int x,int y) {
            num1 = x;
            num2 = y;
        }
        public int Num1
        {
            set { num1 = value; }
            get { return num1; }
        }
        public int Num2
        {
            set { num2 = value; }
            get { return num2; }
        }
        
        public int Add() {
            int sum = 0;
            sum = Num1 + Num2;
            return sum;
            
        }
        public int Subtract() {
            int sub;
            sub = Num1 - Num2;
            return sub;
        }
        public int Multiply() {
            int mulp;
            mulp = Num1 * Num2;
            return mulp;
        }
        public double Divide()
        {
            double div;
            div = (double)Num1 / Num2;
            return div;
        }
    }
}
