using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultithreadingExample
{
   class DelegateThread
    {

        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(DelegateThread));
            log.Info("Calling thread using delegate");
            //ThreadStart obj = new ThreadStart(Test);
            //ThreadStart obj = Test;
            // ThreadStart obj = delegate() { Test(); };
            ThreadStart obj = () => Test();
            Thread t = new Thread(obj);
            t.Start();
            Console.Read();
        }
        /// <summary>
        /// Test method is printing 1 to 100 thread delegate
        /// </summary>
        static void Test()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(DelegateThread));
            for (int i = 1; i <= 100; i++)
            {
                 log.Info("Test =" + i);
            }
        }

       
    }
}
