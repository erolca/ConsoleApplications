using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Working with unchecked code");
        try
        {
            unchecked
            {
                byte b5 = 100, b6 = 200;
                byte b4 = (byte)(b5 + b6);
                Console.WriteLine("b4 = {0}", b4);
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}