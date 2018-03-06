using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultithreadingExample
{
    class ForegroundBackgroundThreadDemo
    {
        static void function1()
        {
            Console.WriteLine("function1 is entered... ");
            //wait hear until user put the any input 
            Console.ReadLine();
            Console.WriteLine("function1 is existing...");
            Console.Read();
        }

        static void Main(string[] args)
        {
            Thread obj = new Thread(function1);
            obj.IsBackground = true;
            obj.Start();
            //control will come here and exist the main functions
            Console.WriteLine("The main application has been exist..");
            Console.Read();
        }
    }
}
