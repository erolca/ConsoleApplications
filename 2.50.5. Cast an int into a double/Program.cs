using System;

class Example
{
    public static void Main()
    {
        double x, y;
        int i;

        x = 10.0;
        y = 3.0;

        i = (int)(x / y); // cast double to int, fractional component lost 
        Console.WriteLine("Integer outcome of x / y: " + i);
        Console.WriteLine();

    }
}