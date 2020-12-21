using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //found complier error when write current without any assignment
            int size, value, head, current=0, longDistance=0,currentDistance=0,MaxValue=0;
            int i, j,len;
            Console.WriteLine("Please enter size of array ");
            size = int.Parse(Console.ReadLine());
            int [] arr= new int[size];
            len = arr.Length;
            
            Console.WriteLine("Please enter values of array elements");
            for (i = 0; i < len; i++)
            {
                value = int.Parse(Console.ReadLine());
                arr[i] = value;

            }
            for (i = 0; i < len; i++)
            {
                head = i;
               
                for (j = i + 1; j < len ; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        current = j;
                    }
                    
                    
                }
                currentDistance = current - head - 1;

                if(currentDistance > longDistance)
                {
                    longDistance = currentDistance;
                    MaxValue = arr[head];
                }
            }
            Console.WriteLine("The Longest Distance is :" + longDistance +"  "+"for The Value "+MaxValue);
        }
    }
}
