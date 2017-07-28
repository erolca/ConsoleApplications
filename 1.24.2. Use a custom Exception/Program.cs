using System;

class RangeArrayException : ApplicationException
{
    public RangeArrayException() : base() { }
    public RangeArrayException(string str) : base(str) { }

    public override string ToString()
    {
        return Message;
    }
}


class MainClass
{
    public static void Main()
    {
        try
        {
            throw new RangeArrayException("Low index not less than high.");
        }
        catch (RangeArrayException exc)
        {
            Console.WriteLine(exc);
        }
    }
}