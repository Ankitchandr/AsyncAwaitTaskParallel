using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace MultithreadingExample
{
    class ThreadPerformance
    {
        public static void incrementCounter1()
        {
            long count = 0;
            for (long i = 0; i <= 1000000; i++)
                count++;
            Console.WriteLine("incrementCounter1=" + count);
        }
        public static void incrementCounter2()
        {
            long count = 0;
            for (long i = 0; i <= 1000000; i++)
                count++;
            Console.WriteLine("incrementCounter2=" + count);
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(incrementCounter1);
            Thread t2 = new Thread(incrementCounter2);
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            s1.Start();
            incrementCounter1();
            incrementCounter2();
            s1.Stop();


            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            t1.Join();
            t2.Join();
            
            Console.WriteLine("single thread taking time = " + s1.ElapsedMilliseconds);
            Console.WriteLine("Multi thread taking time = " + s2.ElapsedMilliseconds);
            Console.Read();

        }
    }
}
