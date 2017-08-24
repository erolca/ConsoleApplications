using System;

// Create an alias for Counter.CountDown. 
using Count = Counter.MyClass;

namespace Counter
{
    class MyClass
    {
    }
}

class MainClass
{
    public static void Main()
    {
        Count cd1 = new Count();
    }
}