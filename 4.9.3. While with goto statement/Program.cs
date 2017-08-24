using System;

class MainClass
{
    static void Main(string[] args)
    {
        int a = 0;

        while (a < 10)
        {
            if (a == 5)
                goto cleanup;
        }
        cleanup:

        Console.WriteLine(a);
    }
}