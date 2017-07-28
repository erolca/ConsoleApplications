using System;

public class MyClass
{
    public void DoAverage()
    {
        try
        {
            int count = 0;
            int average = 10 / count;
        }
        catch (DivideByZeroException e)
        {

            throw (new DivideByZeroException(
            "Count is zero in DoAverage()", e));
        }
    }
}
public class MainClass
{
    public static void Main()
    {
        MyClass my = new MyClass();

        try
        {
            my.DoAverage();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: {0}", e);
        }
    }
}