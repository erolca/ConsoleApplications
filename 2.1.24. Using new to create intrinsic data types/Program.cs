using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        bool b = new bool();            // set to false.
        int i = new int();              // set to 0.
        double d = new double();        // set to 0.0.
        DateTime dt = new DateTime();   // set to 1/1/0001 12:00:00 AM
        Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    }

}