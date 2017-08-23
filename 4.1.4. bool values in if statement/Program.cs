using System;

class Example
{
    public static void Main()
    {
        bool b;

        b = false;
        Console.WriteLine("b is " + b);
        b = true;
        Console.WriteLine("b is " + b);

        // a bool value can control the if statement 
        if (b)
            Console.WriteLine("This is executed.");

        b = false;
        if (b)
            Console.WriteLine("This is not executed.");

    }
}