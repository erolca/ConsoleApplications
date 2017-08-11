using System;

class Example
{
    public static void Main()
    {
        uint u;
        long l;

        l = 64000;
        u = (uint)l;
        Console.WriteLine("u after assigning 64000: " + u +
                          " -- no data lost.");

    }
}