using System;

class MainClass
{
    public static void Main()
    {

        try
        {
            string str = null;
            Console.WriteLine(str.ToString());

        }
        catch (NullReferenceException)
        {
            Console.WriteLine("NullReferenceException!");
            Console.WriteLine("fixing...\n");

        }

    }
}