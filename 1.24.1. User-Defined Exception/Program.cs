using System;

public class CountIsZeroException : ApplicationException
{
    public CountIsZeroException()
    {
    }
    public CountIsZeroException(string message) : base(message)
    {
    }
    public CountIsZeroException(string message, Exception inner) : base(message, inner)
    {
    }
}

class MainClass
{
    public static void Main()
    {
        try
        {
            DoAverage();
        }
        catch (CountIsZeroException e)
        {
            Console.WriteLine("CountIsZeroException: {0}", e);
        }
    }
    public static void DoAverage()
    {
        throw (new CountIsZeroException("Zero count in DoAverage"));
    }

}