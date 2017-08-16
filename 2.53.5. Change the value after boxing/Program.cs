using System;

class MainClass
{
    static void Main()
    {
        int i = 10;
        object oi = i;

        Console.WriteLine("i: {0}, io: {1}", i, oi);

        i = 12;

        Console.WriteLine("i: {0}, io: {1}", i, oi);

        oi = 15;
        Console.WriteLine("i: {0}, io: {1}", i, oi);
    }
}