using System;
using System.Diagnostics;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String str;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int num;
            num = 99999999;  ///this code true only if num contains 9's 
            
            str = num.ToString();
            double len;
            len=str.Length;
            double res;
            res = len * Math.Pow(10.0, len - 1);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}.{1:00}",
                ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("The Number of Ones is : " + " " + res);



        }
    }
}
