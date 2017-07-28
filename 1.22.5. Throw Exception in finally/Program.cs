using System;
using System.Collections;

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
                list.Add(10);

                Console.WriteLine("Item 10 = {0}", list[10]);
            }
            finally
            {
                Console.WriteLine("Cleaning up...");
                throw new Exception("I like to throw");
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Oops!  Argument out of range!");
        }
        catch
        {
            Console.WriteLine("Done");
        }
    }
}