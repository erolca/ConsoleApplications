using System;

class Example
{
    public static void Main()
    {
        byte b;

        b = 10;
        b = (byte)(b * b); // cast needed!

        Console.WriteLine("b: " + b);
    }
}