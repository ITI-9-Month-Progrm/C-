using System;
using System.Diagnostics;
namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, remain,c=0;
            int i, j;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (i = 0; i <100000000; i++)
            {
                num = i;
                while (num != 0)
                {
                    remain = num % 10;
                    if (remain == 1)
                    {
                        c++;
                    }
                    num /= 10;

                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}.{1:00}",
                ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("The number of Ones is : " + c);
        }
    }
}
