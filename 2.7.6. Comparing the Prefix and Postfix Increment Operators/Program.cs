using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IncrementExample
{
    public static void Main()
    {
        int x;

        x = 1;
        System.Console.WriteLine("{0}, {1}, {2}", x++, x++, x);
        System.Console.WriteLine("{0}, {1}, {2}", ++x, ++x, x);
    }
}