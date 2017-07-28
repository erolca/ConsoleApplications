using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThatConsoleClass = System.Console;
using Counter;
using Counter2;


namespace The_Main_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} command line arguments were specified:", args.Length);
            foreach (string arg in args)
                Console.WriteLine("Arg: {0}", arg);


            ThatConsoleClass.WriteLine("Hello");

            // This is CountDown in the Counter namespace. 
            Counter.MyClass m1 = new Counter.MyClass();

            // This is CountDown in the default namespace. 
            Counter2.MyClass m2 = new Counter2.MyClass();

            Console.ReadLine();
        }


    }
}


namespace Counter
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Counter1 namespace.");
        }
    }
}

namespace Counter2
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Counter2 namespace.");
        }
    }
}
