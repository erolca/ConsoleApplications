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
            unchecked
            {
                result = unchecked((byte)(a * b));
                Console.WriteLine("Unchecked result: " + result);

                result = unchecked((byte)(a * b));
                Console.WriteLine("Unchecked result: " + result);
            }

            checked
            {
                result = checked((byte)(a * b));
                Console.WriteLine("Checked result: " + result);

                result = checked((byte)(a * b));
                Console.WriteLine("Checked result: " + result);
            }
        }
        catch (OverflowException exc)
        {
            // catch the exception  
            Console.WriteLine(exc);
        }
    }
}