using System;

class MainClass
{
    public static void Main()
    {

        // use break to exit this loop 
        for (int i = -10; i <= 10; i++)
        {
            if (i > 0) break; // terminate loop when i is positive 
            Console.Write(i + " ");
        }
        Console.WriteLine("Done");
    }
}