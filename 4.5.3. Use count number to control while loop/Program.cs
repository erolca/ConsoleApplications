using System;

class MainClass
{
    public static void Main()
    {
        int num;
        int mag;

        num = 435679;
        mag = 0;

        Console.WriteLine("Number: " + num);

        while (num > 0)
        {
            mag++;
            num = num / 10;
        };

        Console.WriteLine("Magnitude: " + mag);
    }
}