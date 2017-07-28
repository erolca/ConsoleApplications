using System;

class MainClass
{
    public static void Main()
    {

        Console.WriteLine("Receiving ");
        try
        {
            int i = 1, j = 0;

            i = i / j;

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by Zero!");
            return;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("No matching element found.");
        }
        finally
        {
            Console.WriteLine("Leaving try.");
        }
    }

}