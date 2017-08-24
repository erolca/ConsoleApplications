using System;

class MainClass
{
    public static void Main()
    {
        int i, j, d;

        i = 5;
        j = 10;

        if (i != 0)
        {
            Console.WriteLine("i does not equal zero");
            d = j / i;
            Console.WriteLine("j / i is " + d);
        }
    }
}