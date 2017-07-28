using System;

class MainClass
{
    static void Main()
    {
        try
        {

            string str = null;
            str.ToUpper();

        }
        catch (System.NullReferenceException)
        {

            Console.WriteLine("catch clause");

        }
        finally
        {

            Console.WriteLine("finally clause");

        }
    }
}