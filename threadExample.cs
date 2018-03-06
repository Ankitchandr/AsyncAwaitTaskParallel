using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingExample
{

    class threadExample
    {
        /// <summary>
        /// Starting point 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(threadExample));
            log.Info("Starting point (Main method)");
            myThread mt = new myThread();
            Thread td1 = new Thread(new ThreadStart(mt.thread1));
            Thread td2 = new Thread(new ThreadStart(mt.thread2));
            Console.WriteLine("Before starting the thread1=" + td1.IsAlive);
            td1.Start();
            Console.WriteLine("After starting the thread1=" + td1.IsAlive);
            Console.WriteLine("Before starting the thread2=" + td2.IsAlive);
            td2.Start();
            Console.WriteLine("After starting the thread2=" + td2.IsAlive);
            try
            {
               
                // td1.Abort();
                // td2.Abort();
            }
            catch (ThreadAbortException ex)
            {
                log.Error(ex.Message);

            }
            Console.WriteLine("End of thread");
            Console.Read();

        }
    }

/// <summary>
/// In myThread class are created two method thread1 and thread2 
/// </summary>
    public class myThread
    {
        /// <summary>
        /// thread1 is used print 1 to 100 with 500ms sleep
        /// </summary>
       public void thread1()
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(myThread));
            for (int i = 0; i <= 100; i++)
            {
                log.Info(i);
                Thread.Sleep(500);
            }
        }
        /// <summary>
        /// thread2 is used print * with 200ms sleep 
        /// </summary>
        public void thread2()
        {
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(myThread));
            for (int i = 0; i <= 100; i++)
            {
                log.Info("*");
                Thread.Sleep(200);
               
            }
        }

    }

   
}
