using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("System.Byte stats:");
        Console.WriteLine("Max value of byte is {0}.", byte.MaxValue);
        Console.WriteLine("Min value of byte is {0}.", byte.MinValue);

        Console.WriteLine("Catching an underflow");
        try
        {
            byte a = 9, b = 9;
            byte c = (byte)(a + b + -100);
        }
        catch (OverflowException e) { Console.WriteLine(e); }

    }
}