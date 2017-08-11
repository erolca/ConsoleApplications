using System;

class Example
{
    public static void Main()
    {
        uint u;
        long l;

        // cast a long into a uint, data lost 
        l = -12;
        u = (uint)l;
        Console.WriteLine("u after assigning -12: " + u +
                          " -- data lost.");
    }
}