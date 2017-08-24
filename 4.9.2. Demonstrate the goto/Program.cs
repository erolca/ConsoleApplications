using System;

class MainClass
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("i" + i);
            if (i == 3)
                goto stop;
        }
        stop:
        Console.WriteLine("Stopped!");

    }
}