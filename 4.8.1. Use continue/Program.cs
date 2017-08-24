using System;

class MainClass
{
    public static void Main()
    {

        // print even numbers between 0 and 100 
        for (int i = 0; i <= 100; i++)
        {
            if ((i % 2) != 0)
                continue; // iterate 
            Console.WriteLine(i);
        }

    }
}