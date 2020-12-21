using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string inStr; String [] splitStr;
            Console.WriteLine("Please Enter Your Staring");
            inStr = Console.ReadLine();
            splitStr = inStr.Split(" ");
            int len;len = splitStr.Length;
            for(int i = len-1; i >= 0; i--)
            {
                Console.Write(splitStr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
