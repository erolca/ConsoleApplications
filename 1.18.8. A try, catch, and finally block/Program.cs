using System;

class MainClass
{


    public static void TryCatc()
    {

        int x = 10, y = 0;

        try
        {

            x = x / y;

        }
        catch (System.IndexOutOfRangeException)
        {

            Console.WriteLine("catch clause");

        }
        finally
        {

            Console.WriteLine("finally clause");

        }

    }


    public static void Main()
    {

        TryCatc();

        try
        {
            int zero = 0;
            Console.WriteLine("In try block: attempting division by zero");
            int myInt = 1 / zero;
            Console.WriteLine("You never see this message!");
        }
        catch
        {
            Console.WriteLine("In catch block: an exception was thrown");

        }
        finally
        {
            Console.WriteLine("In finally block: do any cleaning up here");
        }
    }
}