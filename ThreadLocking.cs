using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultithreadingExample
{
    class ThreadLocking
    {
        /// <summary>
        /// lock code inside show method
        /// </summary>
        public void show()
        {
            lock (this)
            {
                Console.Write("[ welcome to");
                Thread.Sleep(5000);
                Console.WriteLine(" lara Tech ]");
            }
       }

        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(threadExample));
            log.Info("calling show method through thread");
            ThreadLocking obj = new ThreadLocking();
            Thread t1 = new Thread(obj.show);
            Thread t2 = new Thread(obj.show);
            Thread t3 = new Thread(obj.show);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();

        }
    }
}
