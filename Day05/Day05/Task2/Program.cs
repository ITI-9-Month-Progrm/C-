using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            math operation =new math();
            int Num1 = 2,Num2 = 4;
            Console.WriteLine("Adding Result : "+" "+operation.Add(Num1,Num2));
            Console.WriteLine("Subtract Result : " + " " + operation.Subtract(Num1, Num2));
            Console.WriteLine("Multiply Result : " + " " + operation.Multiply(Num1, Num2));
            Console.WriteLine("Divid Result : " + " " + operation.Divide(Num1, Num2));
            Console.WriteLine("-----------------------Static-----------------------");
            Console.WriteLine("Adding Result : " + " " + mathStatic.Add(Num1, Num2));
            Console.WriteLine("Subtract Result : " + " " + mathStatic.Subtract(Num1, Num2));
            Console.WriteLine("Multiply Result : " + " " + mathStatic.Multiply(Num1, Num2));
            Console.WriteLine("Divid Result : " + " " + mathStatic.Divide(Num1, Num2));
        }
    }
}
