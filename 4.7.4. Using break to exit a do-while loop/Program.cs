using System;

class MainClass
{
    public static void Main()
    {
        int i;

        i = -10;
        do
        {
            if (i > 0)
                break;
            Console.Write(i + " ");
            i++;
        } while (i <= 10);

        Console.WriteLine("Done");
    }
}