using System;
using System.Collections;

public class MyException : Exception
{
    public MyException(String reason, Exception inner) : base(reason, inner)
    {
    }
}

public class MainClass
{
    static void Main()
    {
        try
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add(1);

                Console.WriteLine("Item 10 = {0}", list[10]);
            }
            catch (ArgumentOutOfRangeException x)
            {
                throw new MyException("I'd rather throw this", x);
            }
            finally
            {
                Console.WriteLine("Cleaning up...");
            }
        }
        catch (Exception x)
        {
            Console.WriteLine(x);
            Console.WriteLine("Done");
        }
    }
}