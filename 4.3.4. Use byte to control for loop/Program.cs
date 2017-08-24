using System;

class MainClass
{
    public static void Main()
    {
        byte x;
        int sum;

        sum = 0;
        for (x = 1; x <= 100; x++)
            sum = sum + x;

        Console.WriteLine("Summation of 100 is " + sum);
    }
}