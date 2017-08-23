using System;

class MainClass
{
    public static void Main()
    {
        int i;

        for (i = -5; i <= 5; i++)
        {
            Console.Write("Testing " + i + ": ");

            if (i < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");
        }
    }
}