using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultithreadingExample
{
    class singleThread
    {

        static void Test1()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(singleThread));
            log.Info("Frist Test1 method ");
            for (int i = 1; i <= 100; i++)
            {
                log.Info("Test1 = " +i);
            }
        }
        static void Test2()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(singleThread));
            log.Info("second Test2 method");
            for (int i = 1; i <= 100; i++)
            {
                log.Info("Test2 = " + i);
                if (i == 50)
                {
                    log.Info("Test2 to is sleeping");
                    Thread.Sleep(5000);
                    log.Info("Test2 is wake up");
                }
            }
        }
        static void Test3()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(singleThread));
            log.Info("Third Test3 method ");
            for (int i = 1; i <= 100; i++)
            {
                log.Info("Test3 = " + i);
            }
        }

        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(singleThread));
            log.Info("Single thread Example");
            Thread t1 = new Thread(Test1);
            //Thread t2 = new Thread(Test2);
            //Thread t3 = new Thread(Test3);
            t1.Start();
            //t2.Start();
            //t3.Start();
            Thread t = Thread.CurrentThread;
            t.Name = "My thread";
            Console.WriteLine("my current thread name is=" + " " +Thread.CurrentThread.Name);
            Console.WriteLine("my current thread priority is=" + " " + Thread.CurrentThread.Priority);
            Console.Read();
        }
    }
}
