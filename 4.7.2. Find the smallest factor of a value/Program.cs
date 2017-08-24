using System;

class MainClass
{
    public static void Main()
    {
        int factor = 1;
        int num = 1000;

        for (int i = 2; i < num / 2; i++)
        {
            if ((num % i) == 0)
            {
                factor = i;
                break; // stop loop when factor is found 
            }
        }
        Console.WriteLine("Smallest factor is " + factor);
    }
}