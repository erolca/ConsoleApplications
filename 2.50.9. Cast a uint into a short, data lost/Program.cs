using System;

class Example
{
    public static void Main()
    {
        uint u;
        short s;

        u = 64000;
        s = (short)u;
        Console.WriteLine("s after assigning 64000: " + s +
                          " -- data lost.");
    }
}