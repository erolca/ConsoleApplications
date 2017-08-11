using System;

class Example
{
    public static void Main()
    {
        byte b;
        int i;

        i = 257;
        b = (byte)i;
        Console.WriteLine("b after assigning 257: " + b +
                          " -- data lost.");

    }
}