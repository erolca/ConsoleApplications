using System;

class MainClass
{
    public static void Main()
    {
        byte a, b;
        byte result;

        a = 127;
        b = 127;

        try
        {
            result = unchecked((byte)(a * b));
            Console.WriteLine("Unchecked result: " + result);

            result = checked((byte)(a * b)); // this causes exception 
            Console.WriteLine("Checked result: " + result); // won't execute 
        }
        catch (OverflowException exc)
        {
            // catch the exception  
            Console.WriteLine(exc);
        }
    }
}