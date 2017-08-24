using System;

class MainClass
{
    public static void Main()
    {
        int i, j;

        for (i = 0, j = 10; i < j; i++, j--)
            Console.WriteLine("i and j: " + i + " " + j);
    }
}