using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            math operation=new math(0,0);
            operation.Num1 = 2;
            operation.Num2 = 4;
            Console.WriteLine("Adding Result"+operation.Add());
            Console.WriteLine("Subtract Result"+operation.Subtract());
            Console.WriteLine("Multiply Result"+operation.Multiply());
            Console.WriteLine("Divid Result"+operation.Divide());
        }
    }
}
