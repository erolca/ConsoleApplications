using System;

class MainClass
{
    public static void Main()
    {
        int a, b, c;

        a = 2;
        b = 3;

        if (a < b)
            Console.WriteLine("a is less than b");

        if (a == b)
            Console.WriteLine("you won't see this");

        Console.WriteLine();

        c = a - b;

        Console.WriteLine("c is", c);
        if (c >= 0)
            Console.WriteLine("c is non-negative");
        if (c < 0)
            Console.WriteLine("c is negative");

        Console.WriteLine();

        c = b - a;
        Console.WriteLine("c is", c);
        if (c >= 0)
            Console.WriteLine("c is non-negative");
        if (c < 0)
            Console.WriteLine("c is negative");
    }
}