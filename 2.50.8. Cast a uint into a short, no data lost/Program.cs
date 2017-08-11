using System;

class Example
{
    public static void Main()
    {
        uint u;
        short s;

        u = 32000;
        s = (short)u;
        Console.WriteLine("s after assigning 32000: " + s +
                          " -- no data lost.");
    }
}