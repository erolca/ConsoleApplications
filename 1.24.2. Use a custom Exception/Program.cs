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

        RangeArrayException ext = new RangeArrayException();

        /*uygulamada hata mesajını alırsın*/
        try
        {
            throw new RangeArrayException();
        }
        catch (RangeArrayException exc)
        {
            Console.WriteLine(exc);
        }




        try
        {
            throw new RangeArrayException("Low index not less than high.");
        }
        catch (RangeArrayException exc)
        {
            ext= exc;
            Console.WriteLine(ext);
            //  Console.WriteLine(exc);
        }
    }
}