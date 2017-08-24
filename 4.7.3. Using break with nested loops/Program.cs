using System;

class MainClass
{
    public static void Main()
    {

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Outer loop count: " + i);
            Console.Write("    Inner loop count: ");

            int t = 0;
            while (t < 100)
            {
                if (t == 10)
                    break; // terminate loop if t is 10  
                Console.Write(t + " ");
                t++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Loops complete.");
    }
}