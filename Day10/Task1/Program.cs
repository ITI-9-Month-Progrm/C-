using System;
using System.Linq;
using System.Collections.Generic;
using static Task1.ListGenerators; //syntax suger

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //LINQ - Restriction Operators
            //Q1
            var Result1_1 = ProductList.Where(P => P.UnitsInStock == 0);
            foreach(var item in Result1_1)
            {
                Console.WriteLine(item);
            }

            //Q2
            var Result1_2 = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
             
            foreach (var item in Result1_2)
            {
                Console.WriteLine(item);
            }
            //Q3
            string[] Arr = { "zero", "one", "two",
                              "three", "four", "five", 
                              "six", "seven", "eight", "nine" };
            var Result1_3 = Arr.Where((s, i) => s.Length < i);
            foreach (var item in Result1_3)
            {
                Console.WriteLine(item);
            }

            //--------------------------------------------------------------

            //LINQ - Element Operators
            //Q1
            var Element = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
             Console.WriteLine(Element);
            //Q2
            var Element1 = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            Console.WriteLine(Element1?.ProductName ?? "NULL");
            //Q3
            int[] ArrInt = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result2_3 = ArrInt.Where(i => i > 5);
            var Element2 = Result2_3.ElementAt(1);
            Console.WriteLine("The Second Element : " + Element2);

            //--------------------------------------------------------------

            //Linq-Partitioning Operators
            //Q1
            var Result3_1 = CustomerList.Where(c => c.City == "London").Take(3);
            foreach(var item in Result3_1)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------");
            }
            //Q2
            var Result3_2 = CustomerList.Where(c => c.City == "London").Skip(2);
            foreach (var item in Result3_2)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------");
            }
            //Q3
            int i = 0;
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result3_3 = numbers.TakeWhile(num => num > i++);
            foreach(var item in Result3_3)
            {
                Console.WriteLine(item);
                
            }
            //Q4 --xxx
            int[] numbersDiv = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result3_4 = numbersDiv.SkipWhile(num => num % 3 != 0);
            foreach (var item in Result3_4)
            {
                Console.WriteLine(item);

            }
            //Q5
            
            int j = 0;
            int[] numbersS = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result3_5 = numbersS.SkipWhile(num => num > j++);
            foreach (var item in Result3_5)
            {
                Console.WriteLine(item);

            }


        }
    }
}
