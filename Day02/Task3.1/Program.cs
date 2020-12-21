using System;
using System.Diagnostics;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, j, len , c = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (i = 0; i < 100000000; i++)
            {
                str = i.ToString();
                len = str.Length;
                for (j = 0; j < len; j++)
                {
                    if (str[j] == '1')
                    {
                        c++;
                    }
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
